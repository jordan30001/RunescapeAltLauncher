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

namespace RunescapeLauncher
{


    public partial class Controller : Form
    {
        private const string ValueShowTitleBar = "Show Titlebar";
        private const string ValueHideTitleBar = "Hide Titlebar";
        private const string ValueShowAllTitleBars = "Show All Titlebars";
        private const string ValueHideAllTitleBars = "Hide All Titlebars";

        class ClientItem
        {
            public string ClientID { get; set; }
            public Client Client { get; set; }
        }

        public LauncherConfig Config { get; set; }
        public List<Client> Clients { get; } = new List<Client>();

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
            ProcessWatcher.Timer.Elapsed += new ElapsedEventHandler(RestartIfError);
        }

        public void AddClient(string clientID, Client client)
        {
            Clients.Add(client);
            ListBoxClients.Items.Add(new ClientItem() { Client = client, ClientID = clientID });
            this.Invoke((MethodInvoker)delegate () { ListBoxClients.Refresh(); ListBoxClients.Update(); });
        }

        private void RestartIfError(object sender, ElapsedEventArgs e)
        {
            while (Locks.TryLock(ref Locks.ProccessWatcherLock) == false) Thread.Sleep(5000);
            Clients.ForEach(c => c.RestartIfError());
            Locks.Release(ref Locks.ProccessWatcherLock);
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            Clients.ForEach(c => c.Shutdown());
            Application.Exit();
        }

        private void buttonRestartClient_Click(object sender, EventArgs e)
        {
            if (CurrentClient == null) return;
            while (Locks.TryLock(ref Locks.ProccessWatcherLock) == false) Thread.Sleep(5000);
            CurrentClient.Restart();
            Locks.Release(ref Locks.ProccessWatcherLock);
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
                Decimal.ToInt32(numberBoxHeight.Value)
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
        }

        private void buttonStartClients_Click(object sender, EventArgs e)
        {
            buttonStartClients.Enabled = false;
            List<LauncherInformation> clients = new List<LauncherInformation>();

            string root = Directory.GetCurrentDirectory() + @"\";
            if (Config.CreateDirectoriesForMoreAccounts == true)
            {
                for (int i = 0; i < Config.Accounts.Length; i++)
                {
                    Directory.CreateDirectory(root + "settings-" + i + @"\");
                }
            }

            for (int i = 0; i < Config.Accounts.Length; i++)
            {
                LauncherInformation li = new LauncherInformation
                {
                    Account = Config.Accounts[i],
                    Config = Config,
                    ClientDirectory = root + "settings-" + i + @"\"
                };
                li.Container = new Client
                {
                    LauncherInformation = li
                };

                Thread thread = new Thread(() => Application.Run(li.Container));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                Thread.Sleep(5000);
                li.Container.Invoke((MethodInvoker)delegate () { li.Container.Text = "Client: " + (i + 1); });
                li.Container.Init("Client: " + (i + 1));
                li.Container.Invoke((MethodInvoker)li.Container.LaunchClient);
            }
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
                                        decimal.ToInt32(numberBoxWindowWidth.Value), decimal.ToInt32(numberBoxHeight.Value),
                                        //decimal.ToInt32(numberBoxClientOffsetX.Value), decimal.ToInt32(numberBoxClientOffsetY.Value),
                                        //decimal.ToInt32(numberBoxClientWidth.Value), decimal.ToInt32(numberBoxClientHeight.Value),
                                        decimal.ToInt32(numberBoxLaunchPositionX.Value), decimal.ToInt32(numberBoxLaunchPositionY.Value));
        }
    }

    public static class ProcessWatcher
    {
        public static System.Timers.Timer Timer { get; set; }
        public static HashSet<int> CurrentProcesses { get; } = new HashSet<int>();

        public static void Setup()
        {
            Timer = new System.Timers.Timer(30000)
            {
                Enabled = true,
                AutoReset = true
            };
        }

        public static void FindUndockedClient(LauncherInformation info)
        {
            Process[] processes;
            while (true)
            {
                processes = Process.GetProcessesByName("RuneScape");
                for (int i = 0; i < processes.Length; i++)
                {
                    Process curProc = processes[i];
                    curProc.WaitForInputIdle(1000);
                    if (CurrentProcesses.Add(curProc.Id))
                    {
                        info.RunescapeLauncher = processes[i];
                        while (true)
                        {
                            processes = Process.GetProcessesByName("rs2client");
                            for (int j = 0; j < processes.Length; j++)
                            {
                                curProc = processes[j];
                                curProc.WaitForInputIdle(1000);
                                if (CurrentProcesses.Add(curProc.Id))
                                {
                                    info.Rs2Client = processes[j];
                                    curProc.Refresh();
                                    info.Hwnd = info.Rs2Client.MainWindowHandle;
                                    return;
                                }
                            }
                            Thread.Sleep(1000);
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
