# RunescapeAltLauncher
This is a launcher to automatically launch clients (Useful for alters)

Please note that by default this will move create a new save locations for your settings (Don't worry, your original settings will stay untouched).

It will create 1 settings folder per client launched next to the client named "settings-1, settings-2...settings-N" etc.
this will allow for more than 16 different clients with all different accounts.


the settings.json file contains an "Accounts" section 

"Accounts": [
    {
      "World": 26,
      "WindowSize": [775,550],
      "InitialWindowLocation": [0, 0],
      "WindowLocation": [0,0]
    }
   ]
    
    
World is self explanatory: this will attempt to launch this paticular client on world 26.
WindowSize by default is 775, 550 (this, when logged into the client will remove scrollbars)
InitialWindowLocation, in most cases this can stay as 0,0 and is only used in multi gpu contexts.
  If you do have multi gpu setups and want to utilise more than one GPU, set the InitialWindowLocation to somewhere on the monitor that is attached to the GPU you want to run it on.
WindowLocation self explanatory again, sets the window location of the client

if you wish to add another account to launch duplicate the following json
"
{
      "World": 26,
      "WindowSize": [775,550],
      "InitialWindowLocation": [0, 0],
      "WindowLocation": [0,0]
}
"

and add a comma before the last closing curly brace, moustache, right brace, whichever you prefer to call it.

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
