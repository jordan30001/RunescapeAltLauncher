using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunescapeLauncher
{
    public class LauncherConfig
    {
        //public bool RelaunchClientsOnExit { get; set; }

        public DefaultWorlds WorldInfo { get; } = new DefaultWorlds();

        public bool HideTitleBar { get; set; } = false;
        //public bool UseScrollbars { get; set; } = false;
        //public bool UseAutoLayout { get; } = true;
        //public bool UsingWindowTaskbar { get; } = true;
        //public int TaskbarSize { get; } = 40;
        //public int PriorityClass { get; set; } = 32;

        public bool CreateDirectoriesForMoreAccounts { get; set; } = true;
        public string RunescapeLauncherLocation { get; set; } = @"C:\ProgramData\Jagex\launcher\";
        public string RunescapeLauncher { get; set; } = @"C:\Program Files\Jagex\RuneScape Launcher\RuneScape.exe";
        //public string DefaultSettingsLocation { get; set; }

        [JsonProperty("Accounts")]
        public Account[] Accounts { get; set; }

        public class Account
        {
            public int SettingsFileName { get; set; }
            public int World { get; set; }
            public bool IsF2PAccount { get; set; }
            public int[] InitialWindowLocation { get; set; } = new int[] { 0, 0 };
            public int[] WindowSize { get; set; } = new int[] { 765, 540 };
            public int[] WindowLocation { get; set; } = new int[] { 0, 0 };
        }


        public void InitiateAccounts()
        {
            int curWorldCount = 0;
            int curWorldIndex = 0;
            foreach (Account account in Accounts)
            {
                if(account.World <= 0)
                {
                    account.World = WorldInfo[account.IsF2PAccount][curWorldIndex];
                    curWorldCount++;

                    if (curWorldCount >= 11) 
                    { curWorldCount = 0; 
                        curWorldIndex++; }

                    if(curWorldIndex >= WorldInfo[account.IsF2PAccount].Length) curWorldIndex = 0; 
                }
            }
        }

        public void Save()
        {
            File.WriteAllText(@"settings.json", JsonConvert.SerializeObject(this));
            //Config = JsonConvert.DeserializeObject<LauncherConfig>(File.ReadAllText(@"settings.json"))
        }
    }

    

    public class DefaultWorlds
    {
        
        public int[] this[bool isF2P] { get => isF2P ? F2P : P2P; }
        public int[] F2P { get; } = new int[] { 3, 7, 8, 11, 17, 19, 20, 29, 33, 34, 38, 41, 43, 55, 57, 61, 80, 81, 94, 101, 108, 120, 122, 135, 136, 141 };
        public int[] P2P { get; } = new int[] { 1, 2, 4, 5, 6, 9, 10, 12, 14, 15, 16, 18, 21, 22, 23, 24, 25, 26, 27, 28, 30, 31, 32, 35, 36, 37, 39, 40, 42, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 56, 58, 59, 60, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 82, 83, 84, 85, 86, 87, 88, 89, 91, 92, 96, 97, 98, 99, 100, 102, 103, 104, 105, 106, 114, 115, 116, 117, 118, 119, 121, 123, 124, 134, 137, 138, 139, 140 };


    }
}
