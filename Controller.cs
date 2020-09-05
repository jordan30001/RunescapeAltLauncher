using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static RunescapeLauncher.LauncherConfig;

namespace RunescapeLauncher
{


    public partial class Controller : Form
    {
        private const string ValueShowTitleBar = "Show Titlebar";
        private const string ValueHideTitleBar = "Hide Titlebar";
        private const string ValueShowAllTitleBars = "Show All Titlebars";
        private const string ValueHideAllTitleBars = "Hide All Titlebars";

        private static string RootDirectory { get; } = Directory.GetCurrentDirectory() + @"\";

        private static readonly Func<Account, string> GetClientSettingsFolder = account => RootDirectory + @"settings\" + account.ClientNumber + @"\";

        private static readonly Func<Account, string> GetClientRunescapeSettingsFolder = account => GetClientSettingsFolder(account) + @"RuneScape\";

        class ClientItem
        {
            public string ClientID { get; set; }
            public Client Client { get; set; }
        }

        public LauncherConfig Config { get; set; }
        public List<Client> Clients { get; } = new List<Client>();
        private int ClientNumber = 1;
        private int GetNextClientNumber { get { int temp = ClientNumber; ClientNumber++; return temp; } }

        public Client CurrentClient;

        public Controller()
        {
            InitializeComponent();
            ListBoxClients.DisplayMember = "ClientID";
            ListBoxClients.ValueMember = "Client";
        }

        public void Init()
        {
            ProcessWatcher.Setup();
            bool needsSave = false;

            if (Config.AccountsList.Count > 0) ClientNumber = Config.AccountsList.AsEnumerable().Max(a => a.ClientNumber) + 1;

            //if (Config.CreateDirectoriesForMoreAccounts == true)
            //{
            for (int i = 0; i < Config.AccountsList.Count; i++)
            {
                Account account = Config.AccountsList[i];
                if (account.ClientNumber == -1)
                {
                    account.ClientNumber = GetNextClientNumber;
                    needsSave = true;
                }
                Directory.CreateDirectory(GetClientRunescapeSettingsFolder(account));
            }
            //}
            List<Client> clients = new List<Client>();
            Config.AccountsList.AsEnumerable().ForEach(account => clients.Add(CreateInternalClient(account)));

            Thread.Sleep(2000);
            clients.ForEach(client => InitInternalClient(client, true));

            Config.AccountsList.Sort((a, b) => a.ClientNumber.CompareTo(b.ClientNumber));
            if (needsSave) Config.Save();
        }

        private Client CreateInternalClient(Account account)
        {
            LauncherInformation li = new LauncherInformation
            {
                Account = account,
                Config = Config,
                ClientDirectory = GetClientSettingsFolder(account)
            };
            Client client = li.Container = new Client
            {
                LauncherInformation = li,
                CurrentState = Client.State.HIDDEN
            };

            Thread thread = new Thread(() => { Thread.CurrentThread.Name = "Client Thread"; Application.Run(li.Container); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            return li.Container;
        }

        private Client InitInternalClient(Client client, bool hidden = true, bool wait = false)
        {
            if (wait) Thread.Sleep(2000);
            client.BeginInvoke(new MethodInvoker(delegate
            {
                LauncherInformation lf = client.LauncherInformation;
                if (lf.Account.ClientName == null) lf.Account.ClientName = Convert.ToString(lf.Account.ClientNumber);
                lf.Container.Init(client.LauncherInformation.Account.ClientName);
                if (hidden) lf.Container.Hide();
                else lf.Container.Show();
            }));
            return client;
        }

        public void AddClient(string clientID, Client client)
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    Clients.Add(client);
                    Clients.Sort((a, b) => a.LauncherInformation.Account.ClientNumber.CompareTo(b.LauncherInformation.Account.ClientNumber));
                    ListBoxClients.Items.Clear();
                    Clients.ForEach(c => ListBoxClients.Items.Add(new ClientItem() { Client = c, ClientID = c.LauncherInformation.Account.ClientName }));
                    ListBoxClients.Refresh();
                    ListBoxClients.Update();
                });
            }
            catch (InvalidOperationException ioe)
            {
            }
        }

        private void RestartIfError(object sender, ElapsedEventArgs e)
        {
            Locks.ProccessWatcherLockNew.EnterWriteLock();
            Clients.ForEach(c => c.RestartIfError());
            Locks.ProccessWatcherLockNew.ExitWriteLock();
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            Clients.ForEach(c => c.Shutdown());
            Application.Exit();
        }

        private void buttonRestartClient_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null) return;
            Locks.ProccessWatcherLockNew.EnterWriteLock();
            CurrentClient.Restart();
            Locks.ProccessWatcherLockNew.ExitWriteLock();
        }

        private void buttonClientOffset_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null) return;
            CurrentClient.Invoke((MethodInvoker)delegate ()
            {
                CurrentClient.SetClientOffset(new int[]
                {
                Decimal.ToInt32(numberBoxClientOffsetX.Value),
                Decimal.ToInt32(numberBoxClientOffsetY.Value)
                }, new int[] {
                Decimal.ToInt32(numberBoxClientWidth.Value),
                Decimal.ToInt32(numberBoxClientHeight.Value)
                });
            });
        }

        private void buttonResizeClient_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null) return;

            CurrentClient.Invoke((MethodInvoker)delegate ()
            {
                CurrentClient.SetWindowSize(new int[]
                {
                Decimal.ToInt32(numberBoxWindowX.Value),
                Decimal.ToInt32(numberBoxWindowY.Value)
                }, new int[] {
                Decimal.ToInt32(numberBoxWindowWidth.Value),
                Decimal.ToInt32(numberBoxWindowHeight.Value)
                });
            });
        }

        private void buttonShowTitlebar_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null) return;
            if (buttonShowTitleBar.Text.Equals(ValueShowTitleBar))
            {
                CurrentClient.Invoke((MethodInvoker)delegate () { CurrentClient.ShowTitleBar(true); });
                buttonShowTitleBar.Text = ValueHideTitleBar;
            }
            else
            {
                CurrentClient.Invoke((MethodInvoker)delegate () { CurrentClient.ShowTitleBar(false); });
                buttonShowTitleBar.Text = ValueShowTitleBar;
            }
        }

        private void buttonShowAllTitlebars_Click(object sender, EventArgs e)
        {
            if (buttonShowAllTitlebars.Text == ValueShowAllTitleBars)
            {
                Clients.ForEach(c => c.Invoke((MethodInvoker)delegate () { c.ShowTitleBar(true); }));
                buttonShowAllTitlebars.Text = ValueHideAllTitleBars;
            }
            else
            {
                Clients.ForEach(c => c.Invoke((MethodInvoker)delegate () { c.ShowTitleBar(false); }));
                buttonShowAllTitlebars.Text = ValueShowAllTitleBars;
            }
        }

        private void ListBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentClient = ((ClientItem)ListBoxClients.SelectedItem)?.Client;
            if (CurrentClient == null) return;
            if (CurrentClient.IsTitleBarHidden)
            {
                buttonShowTitleBar.Text = ValueShowTitleBar;
            }
            else
            {
                buttonShowTitleBar.Text = ValueHideTitleBar;
            }
            Account a = CurrentClient.LauncherInformation.Account;
            numberBoxWindowX.Value = a.WindowLocation[0];
            numberBoxWindowY.Value = a.WindowLocation[1];
            numberBoxWindowWidth.Value = a.WindowSize[0];
            numberBoxWindowHeight.Value = a.WindowSize[1];
            numberBoxLaunchPositionX.Value = a.InitialWindowLocation[0];
            numberBoxLaunchPositionY.Value = a.InitialWindowLocation[1];
        }

        private void buttonStartClients_Click(object sender, EventArgs e)
        {
            buttonStartClients.Enabled = false;

            Clients.ForEach(c =>
            {
                try
                {
                    c.CurrentState = Client.State.STOPPED;
                    c.LauncherInformation.Container.LaunchClient();
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.ToString());
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.ToString());

                }
            });
            //ProcessWatcher.Timer.Elapsed += new ElapsedEventHandler(RestartIfError);
        }

        private void buttonUpdateConfigToFile_Click(object sender, EventArgs e)
        {
            Config.Save();
        }

        private void buttonUpdateConfigInMemory_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null) return;

            CurrentClient.UpdateAccount(
                                        decimal.ToInt32(numberBoxWindowX.Value), decimal.ToInt32(numberBoxWindowY.Value),
                                        decimal.ToInt32(numberBoxWindowWidth.Value), decimal.ToInt32(numberBoxWindowHeight.Value),
                                        //decimal.ToInt32(numberBoxClientOffsetX.Value), decimal.ToInt32(numberBoxClientOffsetY.Value),
                                        //decimal.ToInt32(numberBoxClientWidth.Value), decimal.ToInt32(numberBoxClientHeight.Value),
                                        decimal.ToInt32(numberBoxLaunchPositionX.Value), decimal.ToInt32(numberBoxLaunchPositionY.Value));
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            Locks.ClientIncrementerLock.EnterWriteLock();
            int clientNumber = GetNextClientNumber;
            Account account = new Account()
            {
                ClientName = ShowDialog("Client Name", @"Please enter the name (alpha-numeric or spaces only) of this client.
                or nothing to set the name to the client number.", Convert.ToString(clientNumber)),
                ClientNumber = clientNumber
            };
            Config.AddAccount(account);
            Locks.ClientIncrementerLock.ExitWriteLock();

            Client client = CreateInternalClient(account);
            if (buttonStartClients.Enabled)
            {
                InitInternalClient(client, true, true);
            }
            else
            {
                InitInternalClient(client, false, true);
                client.LauncherInformation.Container.LaunchClient();
            }

        }

        private void buttonBatchAddClient_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog settingsDirectory = new FolderBrowserDialog();
            if (settingsDirectory.ShowDialog(this) == DialogResult.OK)
            {
                string folder = settingsDirectory.SelectedPath;
                string[] settingFiles = Directory.GetFiles(folder, "*.jcache", SearchOption.TopDirectoryOnly);

                List<Client> clients = new List<Client>();

                Locks.ClientIncrementerLock.EnterWriteLock();
                for (int i = 0; i < settingFiles.Length; i++) clients.Add(CreateInternalClient(new Account { ClientNumber = GetNextClientNumber }));
                Locks.ClientIncrementerLock.ExitWriteLock();


                Thread.Sleep(2000);
                bool shouldShowWindow = buttonStartClients.Enabled == true;
                for (int i = 0; i < clients.Count; i++)
                {
                    Client client = InitInternalClient(clients[i], shouldShowWindow, false);
                    Directory.CreateDirectory(GetClientRunescapeSettingsFolder(client.LauncherInformation.Account));
                    string destSettingsFiles = GetClientRunescapeSettingsFolder(client.LauncherInformation.Account) + "settings.jcache";
                    File.Copy(settingFiles[i], destSettingsFiles, true);

                    Config.AccountsList.Add(client.LauncherInformation.Account);
                }

                Config.Save();
                if (buttonStartClients.Enabled == false) clients.ForEach(client => client.LaunchClient());
            }
        }

        private static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            string retVal = prompt.ShowDialog() == DialogResult.OK ? textBox.Text : defaultValue;
            if (retVal.Equals("")) retVal = defaultValue;

            return retVal;
        }

        private void buttonFitClientToWindow_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null) return;
            CurrentClient.FitClientToWindow();
        }

        private void buttonFitAllClientsToWindow_Click(object sender, EventArgs e)
        {
            Clients.ForEach(c => c.FitClientToWindow());
        }
    }

    public static class ProcessWatcher
    {
        public static System.Timers.Timer Timer { get; set; }
        public static HashSet<int> CurrentProcesses { get; } = new HashSet<int>();
        private static object Lock = new object();

        public static bool Add(int proc)
        {
            while (Locks.TryLock(ref Lock) == false) Thread.Sleep(1000);
            bool result = CurrentProcesses.Add(proc);
            Locks.Release(ref Lock);
            return result;
        }

        public static bool Remove(int proc)
        {
            while (Locks.TryLock(ref Lock) == false) Thread.Sleep(1000);
            bool result = CurrentProcesses.Remove(proc);
            Locks.Release(ref Lock);
            return result;
        }

        public static void Setup()
        {
            Timer = new System.Timers.Timer(30000)
            {
                Enabled = true,
                AutoReset = true
            };
        }

        public static bool FindUndockedClient(LauncherInformation info)
        {
            int tryCount = 0;
            Process[] processes;
            while (true)
            {
                processes = Process.GetProcessesByName("RuneScape");
                for (int i = 0; i < processes.Length; i++)
                {
                    Process curProc = processes[i];
                    curProc.WaitForInputIdle(1000);
                    if (ProcessWatcher.Add(curProc.Id))
                    {
                        info.RunescapeLauncher = processes[i];
                        tryCount = 0;
                        while (true)
                        {
                            processes = Process.GetProcessesByName("rs2client");
                            for (int j = 0; j < processes.Length; j++)
                            {
                                curProc = processes[j];
                                curProc.WaitForInputIdle(1000);
                                if (ProcessWatcher.Add(curProc.Id))
                                {
                                    info.Rs2Client = processes[j];
                                    curProc.Refresh();
                                    info.Hwnd = info.Rs2Client.MainWindowHandle;
                                    return true;
                                }
                            }
                            if (tryCount++ == 20) return false;
                            Thread.Sleep(1000);
                        }
                    }
                }
                if (tryCount++ == 20) return false;
                Thread.Sleep(1000);
            }
        }
    }
}
