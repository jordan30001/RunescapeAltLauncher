using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static RunescapeLauncher.LauncherConfig;

namespace RunescapeLauncher
{
    static class Program
    {
        public static Controller Controller { get; private set; }
        static void Main()
        {
            //
            if (AdminChecks() == false) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Launch(config, config.Accounts[0]);

            Controller = new Controller
            {
                Config = JsonConvert.DeserializeObject<LauncherConfig>(File.ReadAllText(@"settings.json"))
            };
            Controller.Config.Init();
            Thread thread = new Thread(() =>
            {
                Controller.Init();
                Application.Run(Controller);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private static bool AdminChecks()
        {
            if (!IsRunAsAdministrator())
            {
                var processInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);

                // The following properties run the new process as administrator
                processInfo.UseShellExecute = true;
                processInfo.Verb = "runas";

                // Start the new process
                try
                {
                    Process.Start(processInfo);
                }
                catch (Exception)
                {
                    // The user did not allow the application to run as administrator
                    MessageBox.Show("Sorry, this application must be run as Administrator.");
                }

                // Shut down the current process
                Application.Exit();
                return false;

            }
            return true;


        }
        private static bool IsRunAsAdministrator()
        {
            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);

            return wp.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }

    public class LauncherInformation
    {
        public IntPtr Hwnd { get; set; }
        public Process RunescapeLauncher { get; set; }
        public Process Rs2Client { get; set; }
        public LauncherConfig Config { get; set; }
        public Account Account { get; set; }
        public Client Container { get; set; }
        public string ClientDirectory { get; internal set; }
    }

    public static class WindowUtils
    {
        const int WS_BORDER = 8388608;
        const int WS_DLGFRAME = 4194304;
        const int WS_CAPTION = WS_BORDER | WS_DLGFRAME;
        const int WS_SYSMENU = 524288;
        const int WS_THICKFRAME = 262144;
        const int WS_MINIMIZE = 536870912;
        const int WS_MAXIMIZEBOX = 65536;
        const int GWL_STYLE = (int)-16L;
        const int GWL_EXSTYLE = (int)-20L;
        const int WS_EX_DLGMODALFRAME = (int)0x1L;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOSIZE = 0x1;
        const int SWP_FRAMECHANGED = 0x20;
        const uint MF_BYPOSITION = 0x400;
        const uint MF_REMOVE = 0x1000;


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        private static extern bool EnableScrollBar(IntPtr hWnd, int wbar, bool show);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);


        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern IntPtr SetWindowLongPtr32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "ShowScrollBar")]
        public static extern bool ShowScrollBar(IntPtr Hwnd, int wbar, bool bShow);


        private static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 8)
                return GetWindowLongPtr64(hWnd, nIndex);
            else
                return GetWindowLongPtr32(hWnd, nIndex);
        }

        private static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, int dwNewLong)
        {
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            else
                return SetWindowLongPtr32(hWnd, nIndex, dwNewLong);
        }

        public static void MakeExternalWindowBorderless(IntPtr hWnd)
        {
            int Style = 0;
            Style = (int)GetWindowLongPtr(hWnd, GWL_STYLE);
            Style = Style & ~WS_CAPTION;
            Style = Style & ~WS_SYSMENU;
            Style = Style & ~WS_THICKFRAME;
            Style = Style & ~WS_MINIMIZE;
            Style = Style & ~WS_MAXIMIZEBOX;
            SetWindowLongPtr(hWnd, GWL_STYLE, Style);
            Style = (int)GetWindowLongPtr(hWnd, GWL_EXSTYLE);
            SetWindowLongPtr(hWnd, GWL_EXSTYLE, Style | WS_EX_DLGMODALFRAME);
            SetWindowPos(hWnd, new IntPtr(0), 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);
        }

        public static void SetWindowDimensions(IntPtr hWnd, int x, int y, int w, int h)
        {
            SetWindowPos(hWnd, new IntPtr(0), x, y, w, h, 0);
        }

        internal static void RefreshWindow(IntPtr hwnd)
        {
            SetWindowPos(hwnd, new IntPtr(0), 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_FRAMECHANGED);
        }

        public static void SetWindowSize(IntPtr hWnd, int[] position, int[] widthHeight)
        {
            SetWindowDimensions(hWnd, position[0], position[1], widthHeight[0], widthHeight[1]);
        }

        public static void SetWindowScrollbars(IntPtr hWnd, bool show)
        {
            //EnableScrollBar(hWnd, 0x3, show);
            ShowScrollBar(hWnd, 0, show);
        }

        public static void KillProcessTree(int? pid)
        {
            int _pid = pid.GetValueOrDefault(0);
            if (_pid == 0) return;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessTree(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(_pid);
                proc.Kill();
            }
            catch (Exception ae)
            {
            }
        }
    }

    public static class Locks
    {
        public static ReaderWriterLockSlim ProccessWatcherLockNew = new ReaderWriterLockSlim();
        public static ReaderWriterLockSlim LauncherLockNew = new ReaderWriterLockSlim();
        public static ReaderWriterLockSlim ClientIncrementerLock = new ReaderWriterLockSlim();

        internal static bool TryLock(ref object theLock)
        {
            bool locked = false;
            Monitor.TryEnter(theLock, ref locked);
            return locked;
        }

        internal static void Release(ref object launcherLock)
        {
            Monitor.Exit(launcherLock);
        }
    }

    public static class RegistryInfo
    {
        private static RegistryKey[] Keys = new RegistryKey[16];

        public static void SetAllClientPositionRegistryKeys(string value)
        {
            Monitor.Enter(Keys);
            if (Keys[0] == null)
            {
                const string RegistryKey = @"SOFTWARE\Jagex\RuneScape";
                string curKey = RegistryKey;
                for (int i = 0; i < 16; i++)
                {
                    if (i > 0)
                    {
                        curKey = RegistryKey + "-" + i;
                    }
                    Keys[i] = Registry.CurrentUser.OpenSubKey(curKey, true);
                }
            }
            Monitor.Exit(Keys);
            for (int i = 0; i < Keys.Length; i++)
            {
                Keys[i].SetValue("client_position", value, RegistryValueKind.String);
            }
        }
    }

    public static class Int32Extension
    {
        public static void IntToBytes(this int source, ref byte[] bytes, int offset = 0)
        {
            bytes[offset + 0] = (byte)(source >> 24);
            bytes[offset + 1] = (byte)(source >> 16);
            bytes[offset + 2] = (byte)(source >> 8);
            bytes[offset + 3] = (byte)(source);
        }
    }

    public static class IEnumerableExtension
    {
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration) action(item);
        }
    }
}

