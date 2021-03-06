﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static RunescapeLauncher.Controller;
using static RunescapeLauncher.LauncherConfig;

namespace RunescapeLauncher
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public enum State
        {
            HIDDEN,
            STOPPED,
            STARTING,
            RUNNING
        }

        public LauncherInformation LauncherInformation { get; set; }
        public bool IsTitleBarHidden { get; set; }
        private bool AllowShutdown { get; set; }
        public State CurrentState { get; set; }

        private int TitleHeight { get; set; }

        private object SelfLock = new object();


        const string RSParamsRequestOld = "http://world{0}.runescape.com/k=5/l=0/jav_config.ws?binaryType=2";
        const string RSLaunchParams = @"""--configURI"" ""rs-launch://world{0}.runescape.com/k=5/l=$(Language:0)/jav_config.ws""";

        public void Init(string clientID)
        {
            this.Text = LauncherInformation.Account.ClientName;
            //IsTitleBarHidden = LauncherInformation.Config.HideTitleBar;
            Program.Controller.AddClient(clientID, this);
            LocationChanged += new System.EventHandler(delegate (object sender, EventArgs e)
            {
                LauncherInformation.Account.WindowLocation[0] = DesktopBounds.X;
                LauncherInformation.Account.WindowLocation[1] = DesktopBounds.Y;
                LauncherInformation.Account.WindowSize[0] = DesktopBounds.Width;
                LauncherInformation.Account.WindowSize[1] = DesktopBounds.Height;
            });

            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            TitleHeight = screenRectangle.Top - this.Top;
        }

        public void LaunchClient()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                Locks.LauncherLockNew.EnterWriteLock();
                while (Locks.TryLock(ref SelfLock) == false) Thread.Sleep(1000);
                if (CurrentState != State.STOPPED)
                {
                    Locks.Release(ref SelfLock);
                    Locks.LauncherLockNew.ExitWriteLock();
                    return;
                }
                if (IsRunning(LauncherInformation.Rs2Client) && IsRunning(LauncherInformation.RunescapeLauncher))
                {
                    Locks.Release(ref SelfLock);
                    Locks.LauncherLockNew.ExitWriteLock();
                    return;
                }
                CurrentState = State.STARTING;
                this.Show();

                while (true)
                {
                    Process killhandle = new Process();
                    killhandle.StartInfo.FileName = @"C:\Program Files\LockHunter\Lockhunter.exe";
                    killhandle.StartInfo.Arguments = @"-d -sm -x C:\ProgramData\Jagex\launcher\instance.lock";
                    killhandle.Start();
                    killhandle.WaitForExit();
                    LauncherInformation.RunescapeLauncher = new Process();


                    try
                    {
                        string args = String.Join(" ", RSLaunchParams.Replace("{0}", LauncherInformation.Account.World + ""));
                        LauncherInformation.RunescapeLauncher.StartInfo.FileName = LauncherInformation.Config.RunescapeLauncher;
                        LauncherInformation.RunescapeLauncher.StartInfo.Arguments = args;
                        LauncherInformation.RunescapeLauncher.StartInfo.UseShellExecute = false;


                        //if (LauncherInformation.Config.CreateDirectoriesForMoreAccounts)
                        //{
                        string data = File.ReadAllText(LauncherInformation.Config.RunescapeLauncherLocation + "preferences.cfg");
                        data = Regex.Replace(data, "(user_folder=).+", "$1" + LauncherInformation.ClientDirectory);
                        File.WriteAllText(LauncherInformation.Config.RunescapeLauncherLocation + "preferences.cfg", data);
                        //}

                        if (LauncherInformation.Account.InitialWindowLocation != null)
                        {
                            int offset = 18;
                            byte[] bytes = new byte[]
                            {
                            //randon crap?
                            0b00000000, 0b00000001, 0b11111111, 0b11111111,
                            0b11111111, 0b11111111, 0b11111111, 0b11111111,
                            0b11111111, 0b11111111, 0b11111111, 0b11111111,
                            0b11111111, 0b11111111, 0b11111111, 0b11111111,
                            0b11111111, 0b11111111,
                            //blank data for writing too
                            //x
                            0, 0, 0, 0,
                            //y
                            0, 0, 0, 0,
                            //width (x + width)
                            0, 0, 0, 0,
                            //height (y + height)
                            0, 0, 0, 0
                               };
                            IntsToBytes(
                                ref bytes,
                                offset,
                                LauncherInformation.Account.InitialWindowLocation[0],
                                LauncherInformation.Account.InitialWindowLocation[1]);

                            string encoded = System.Convert.ToBase64String(bytes, Base64FormattingOptions.None);

                            RegistryInfo.SetAllClientPositionRegistryKeys(encoded);
                        }

                        LauncherInformation.RunescapeLauncher.Start();

                        bool success = ProcessWatcher.FindUndockedClient(LauncherInformation);

                        if (success == false)
                        {
                            try { if (LauncherInformation.RunescapeLauncher != null) WindowUtils.KillProcessTree(LauncherInformation.RunescapeLauncher.Id); } catch (Exception ioe) { }
                            try { if (LauncherInformation.Rs2Client != null) WindowUtils.KillProcessTree(LauncherInformation.Rs2Client.Id); } catch (Exception ioe) { }
                            if (LauncherInformation.Rs2Client != null)
                            {
                                try { ProcessWatcher.Remove(LauncherInformation.Rs2Client.Id); } catch (Exception ioe) { }
                            }
                            if (LauncherInformation.RunescapeLauncher != null)
                            {
                                try { ProcessWatcher.Remove(LauncherInformation.RunescapeLauncher.Id); } catch (Exception ioe) { }
                            }
                            LauncherInformation.Rs2Client = LauncherInformation.RunescapeLauncher = null;
                            CurrentState = State.STOPPED;
                            Locks.LauncherLockNew.ExitWriteLock();
                            Locks.Release(ref SelfLock);
                            Restart();
                        }
                        DockIt();
                        Locks.LauncherLockNew.ExitWriteLock();
                        Locks.Release(ref SelfLock);
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            });

        }

        private void DockIt()
        {
            int attempts = 20;
            while (LauncherInformation.Hwnd == IntPtr.Zero)
            {
                if (LauncherInformation.Rs2Client == null || LauncherInformation.RunescapeLauncher == null)
                {
                    CurrentState = State.STOPPED;
                    Restart(true); 
                    return;
                }
                if (LauncherInformation.Rs2Client.HasExited)
                {
                    CurrentState = State.STOPPED;
                    return;
                }
                LauncherInformation.Rs2Client.WaitForInputIdle(1000);
                LauncherInformation.Rs2Client.Refresh();
                if (LauncherInformation.Rs2Client.HasExited)
                {
                    CurrentState = State.STOPPED;
                    return;
                }
                LauncherInformation.Hwnd = LauncherInformation.Rs2Client.MainWindowHandle;
                if (LauncherInformation.Hwnd != IntPtr.Zero) break;
                if (attempts-- == 0)
                {
                    CurrentState = State.STOPPED;
                    Restart(true);
                    return;
                }
                Thread.Sleep(1000);
            }
            WindowUtils.SetParent(LauncherInformation.Hwnd, mainPanel.Handle);

            int[] windowSize = LauncherInformation.Account.WindowSize;
            int[] windowLocation = LauncherInformation.Account.WindowLocation;

            WindowUtils.MakeExternalWindowBorderless(LauncherInformation.Hwnd);
            if (LauncherInformation.Config.HideTitleBar)
            {
                ShowTitleBar(false);
            }
            else
            {
                ShowTitleBar(true);
            }
            SetWindowSize(windowLocation, windowSize);

            this.FormClosing += new FormClosingEventHandler(WindowClosing);
            CurrentState = State.RUNNING;
        }

        public void UpdateAccount(int wX, int wY, int wWidth, int wHeight, /*int cOffsX, int cOffsY, int cW, int cH, */int lpx, int lpy)
        {
            Account account = LauncherInformation.Account;
            account.WindowSize = new int[2] { wWidth, wHeight };
            account.WindowLocation = new int[2] { wX, wY };
            account.InitialWindowLocation = new int[2] { lpx, lpy };
        }

        public static bool IsRunning(Process process)
        {
            if (process == null) return false;

            try
            {
                Process.GetProcessById(process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        /*
                private void MainPanel_Resize(object sender, EventArgs e)
                {
                    WindowUtils.SetWindowDimensions(LauncherInformation.Hwnd, 0, 0, mainPanel.Width + 10, mainPanel.Height + 10);

                }*/

        private void WindowClosing(object sender, FormClosingEventArgs e)
        {
            if (AllowShutdown) return;
            e.Cancel = true;
            return;
        }

        public override string ToString()
        {
            return Name;
        }

        public void ShowTitleBar(bool showWindowTitleBar)
        {
            Size size = this.Size;
            if (showWindowTitleBar && IsTitleBarHidden)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                size.Height += TitleHeight;
                IsTitleBarHidden = false;
            }
            else if (IsTitleBarHidden == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;

                size.Height -= TitleHeight;
                IsTitleBarHidden = true;
            }
            this.Size = size;
        }

        public void SetWindowSize(int[] position, int[] size)
        {
            int offset;
            if (IsTitleBarHidden)
            {
                offset = 2;
            }
            else
            {
                offset = 35;
            }

            this.Size = new System.Drawing.Size(size[0] + 5, size[1] + offset);
            this.SetDesktopBounds(position[0], position[1], size[0] + 5, size[1] + offset);

            SetClientOffset(new int[] { 0, 0 }, LauncherInformation.Account.WindowSize);
            LauncherInformation.Account.WindowLocation = position;
            LauncherInformation.Account.WindowSize = size;
        }

        public void SetClientOffset(int[] offset, int[] size)
        {
            WindowUtils.SetWindowSize(LauncherInformation.Hwnd, offset, size);
            LauncherInformation.Account.WindowSize = size;
        }

        public void RestartIfError()
        {
            if (LauncherInformation.Rs2Client == null
                || LauncherInformation.RunescapeLauncher == null)
            {
                Restart();
                return;
            }

            LauncherInformation.Rs2Client.Refresh();
            LauncherInformation.RunescapeLauncher.Refresh();
            if (LauncherInformation.Rs2Client.HasExited
                || LauncherInformation.RunescapeLauncher.HasExited)
            {
                Restart();
            }
        }

        public void Restart(bool force = false)
        {
            while (Locks.TryLock(ref SelfLock) == false) Thread.Sleep(1000);
            if (CurrentState != State.RUNNING && force == false) return;
            if (AllowShutdown) return;
            try { if (LauncherInformation.RunescapeLauncher != null) WindowUtils.KillProcessTree(LauncherInformation.RunescapeLauncher.Id); } catch (Exception ioe) { }
            try { if (LauncherInformation.Rs2Client != null) WindowUtils.KillProcessTree(LauncherInformation.Rs2Client.Id); } catch (Exception ioe) { }
            if (LauncherInformation.Rs2Client != null)
            {
                try { ProcessWatcher.Remove(LauncherInformation.Rs2Client.Id); } catch (Exception ioe) { }
            }
            if (LauncherInformation.RunescapeLauncher != null)
            {
                try { ProcessWatcher.Remove(LauncherInformation.RunescapeLauncher.Id); } catch (Exception ioe) { }
            }
            LauncherInformation.Rs2Client = LauncherInformation.RunescapeLauncher = null;
            CurrentState = State.STOPPED;
            BeginInvoke((MethodInvoker)LaunchClient);
            Locks.Release(ref SelfLock);
        }

        internal void Shutdown()
        {
            this.AllowShutdown = true;
            CurrentState = State.STOPPED;
            try { WindowUtils.KillProcessTree(LauncherInformation?.RunescapeLauncher?.Id); } catch (Exception ioe) { }
            try { WindowUtils.KillProcessTree(LauncherInformation?.Rs2Client?.Id); } catch (Exception ioe) { }
        }

        internal void FitClientToWindow()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                int[] windowSize = LauncherInformation.Account.WindowSize;
                int[] windowLocation = LauncherInformation.Account.WindowLocation;

                WindowUtils.MakeExternalWindowBorderless(LauncherInformation.Hwnd);
                SetWindowSize(windowLocation, windowSize);
            });
        }

        public static void IntsToBytes(ref byte[] buffer, int offset, params int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i].IntToBytes(ref buffer, (i * 4) + offset);
            }
        }
    }
}
