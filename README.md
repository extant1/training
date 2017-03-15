# Life is Feudal Training Server Script
Version 1.0

This is a training server assistance script to help spawn items in, heal the player, and set their stats.
This REQUIRES GM power and will not work without.

---------------

## Installation


* Go to your life is feudal game directory and create a folder called 'mod' if this does not exist already.

* After downloading/extracting the files rename the folder from training-master to training. *(Unless you just want to change the exec command further on.)*

* Copy the 'training' folder into the 'mod' folder.

* Open the console and type:

			exec("mod/training/init.cs");

##### NOTE:  
This will only keep the script loaded while the game is running.  When the game closes the script
will need to be executed (exec) again to use.

*I will update the instructions to run the script automatically every time the game is run after some testing.*


---------------

## New Players

If this is your first time on the training server be sure to run the gm command:

			/gm <password>
			
Then open your console using 'Ctrl + ~' and type 'newplayer' without the quotes.
This will set all your skills and alignment to maximum.

Next you will want to use the stats() command to set your player stats.  Then
stats command requires five arguments in the correct order (strength, agility, constitution, intel, willpower)
to work.

EXAMPLE:

			stats(30, 20, 70, 14, 16)
			
			Would be 30 strength, 20 agility, 70 constitution, 14 intell, 16 willpower

			
---------------

## Healing


Press 'Alt + H' to heal.  Don't be a dick and cheat.


---------------

## Player

newplayer = All maxskills + alignment  
alignment = Alignment to 1000  
maxskills = All skills to 100  
minor = All minor skills to 100  
crafting = All crafting skills to 100  
special = All special combat skills to 100 (Equipment maintain, battle survival, drill)  
armor = All armor skills to 100  
combat = All combat skills to 100  

---------------

## Items

All weapons, armor, and horses take an optional quality argument.
Some common or difficult to spell weapons have aliases for convenience.  
EXAMPLE:  
			`royalchain(75)`  
			`boarspear(100)`  
  
All arrows or bolts take a required quantity argument.   
EXAMPLE:   
			`heavybolt(30)`  
  
## Armors(quality)
regularpadded  
heavypadded  
royalpadded  
regularscale  
heavyscale  
royalscale  
regularleather  
heavyleather  
royalleather  
regularchain  
heavychain  
royalchain  
halfplate  
fullplate  
royalplate  

## Poleaxes(quality)
partisan **OR** p  

## Spears(quality)
boarspear **OR** bs  
shortpike  
mediumpike  
longpike  

## Lances(quality)
jousting  
lance  
decorated  

## 2H Sword(Quality)
zweihaender **OR** zwei  
claymore  
bigfalchion  
flamberge  

## Blunt (Quality)
maul  
warpick  
mace  
cudgel  
morningstar  

## 1H Sword(Quality)
falchion  
scimitar  
nordic  
knight  
lightsabre  

## Bows(quality)
shortbow  
longbow  
compositebow  

## Crossbows(quality)
lightcrossbow  
heavycrossbow  
arbalest  

## Thrown Weapons (quality)
throwingknife  
javelin  
throwingaxe  

## Arrows(Quantity)
arrow  
broadhead  
fire  
firework  
dull  
bodkin  

## Bolts(Quantity)
bolt  
dullbolt  
heavybolt  
fireworkbolt  

## Shields(Quality)
targe  
heavytarge  
heater  
kite  
tower  
pavise  

## Misc(Quality)
tabard  

## Horses(Quality)
warhorse  
spirited  
hardy  
heavy  	