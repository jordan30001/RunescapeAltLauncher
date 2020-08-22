# RunescapeAltLauncher
This is a launcher to automatically launch clients (Useful for alters)

Please note that by default this will move create a new save locations for your settings (Don't worry, your original settings will stay untouched).

It will create 1 settings folder per client launched next to the client named "settings-1, settings-2...settings-N" etc.
this will allow for more than 16 different clients with all different accounts.


the settings.json file contains information on how to launch clients.

There are currently the following options:

HideTitleBar (true/false) - will automatically hide titlebars on clients launched

CreateDirectoriesForMoreAccounts (true/false) - will create directories next to the launcher named "settings-0, settings-1" etc for each client (this bypasses the limit of 16 account settings saved at once)

RunescapeLauncherLocation - this is the location of the rs2client directory
RunescapeLauncher - this is the location of the runescape launchers executable

Accounts - this contains a list of client data and has sub options.

  Accounts.InitialWindowLocation (2 whole numbers) - this is the x, y location of a monitor to launch the clients on to use the GPU attached to that monitor (used for multi-gpus)
  Accounts.WindowSize (2 whole numbers) - this is the window size
  Accounts.WindowLocation (2 whole numbers) - this is the location that the clients will be when they are fully launched

if you wish to add another account to launch duplicate the following json

```
{
      "World": 26,
      "WindowSize": [775,550],
      "InitialWindowLocation": [0, 0],
      "WindowLocation": [0,0]
}
```

and add a comma before the last closing curly brace, moustache, right brace, whichever you prefer to call it.

```
"Accounts": [
    {
      "World": 26,
      "WindowSize": [775,550],
      "InitialWindowLocation": [0, 0],
      "WindowLocation": [0,0]
    },
    {
      "World": 26,
      "WindowSize": [775,550],
      "InitialWindowLocation": [0, 0],
      "WindowLocation": [0,0]
    }
]
```
