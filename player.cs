function stats(%str, %agl, %con, %int, %wil){
	// sets the players stats, arguments are required
	if(%str){
		//strength
		cmChatCommand("@", "/setmystat 0 " @ %str);
		//agility
		cmChatCommand("@", "/setmystat 1 " @ %agl);
		//constitution
		cmChatCommand("@", "/setmystat 4 " @ %con);
		//intelligence
		cmChatCommand("@", "/setmystat 3 " @ %int);
		//willpower
		cmChatCommand("@", "/setmystat 2 " @ %wil);
	}
	else {
		echo("********************************************");
		echo("");
		echo("stats(Strength, Agility, Constitution, Intelligence, Willpower)");
		echo("You must run the command with the stats as paramters");
		echo("");
		echo("EXAMPLE:  stats(30, 20, 70, 14, 16)");
		echo("");
		echo("Would be 30 strength, 20 agility, 70 constitution, 14 intell, 16 willpower");
		echo("");
		echo("********************************************");
	}
}

function combat(){
	// Sets combat skills
	echo("********************************************");
	echo("");
	echo("## Setting all combat skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'chivalry' 100");
	cmChatcommand("@", "/setmyskill 'spear mastery' 100");
	cmChatcommand("@", "/setmyskill 'poleaxes mastery' 100");
	cmChatcommand("@", "/setmyskill 'unit and formation' 100");
	cmChatcommand("@", "/setmyskill 'mounted fighting mastery' 100");
	cmChatcommand("@", "/setmyskill 'lancing' 100");
	cmChatcommand("@", "/setmyskill 'heavy horse handling' 100");
	cmChatcommand("@", "/setmyskill 'blades mastery' 100");
	cmChatcommand("@", "/setmyskill 'shield mastery' 100");
	cmChatcommand("@", "/setmyskill 'piercing mastery' 100");
	
	cmChatcommand("@", "/setmyskill 'warrior' 100");
	cmChatcommand("@", "/setmyskill 'demolition' 100");
	cmChatcommand("@", "/setmyskill 'two-handed axes mastery' 100");
	cmChatcommand("@", "/setmyskill 'two-handed blunt mastery' 100");
	// Stats
function stats(%str, %agl, %con, %int, %wil){
	// sets the players stats, arguments are required
	if(%str){
		//strength
		cmChatCommand("@", "/setmystat 0 " @ %str);
		//agility
		cmChatCommand("@", "/setmystat 1 " @ %agl);
		//constitution
		cmChatCommand("@", "/setmystat 4 " @ %con);
		//intelligence
		cmChatCommand("@", "/setmystat 3 " @ %int);
		//willpower
		cmChatCommand("@", "/setmystat 2 " @ %wil);
	}
	else {
		echo("********************************************");
		echo("");
		echo("stats(Strength, Agility, Constitution, Intelligence, Willpower)");
		echo("You must run the command with the stats as paramters");
		echo("");
		echo("EXAMPLE:  stats(30, 20, 70, 14, 16)");
		echo("");
		echo("Would be 30 strength, 20 agility, 70 constitution, 14 intell, 16 willpower");
		echo("");
		echo("********************************************");
	}
}

function combat(){
	// Sets combat skills
	echo("********************************************");
	echo("");
	echo("## Setting all combat skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'chivalry' 100");
	cmChatcommand("@", "/setmyskill 'spear mastery' 100");
	cmChatcommand("@", "/setmyskill 'poleaxes mastery' 100");
	cmChatcommand("@", "/setmyskill 'unit and formation' 100");
	cmChatcommand("@", "/setmyskill 'mounted fighting mastery' 100");
	cmChatcommand("@", "/setmyskill 'lancing' 100");
	cmChatcommand("@", "/setmyskill 'heavy horse handling' 100");
	cmChatcommand("@", "/setmyskill 'blades mastery' 100");
	cmChatcommand("@", "/setmyskill 'shield mastery' 100");
	cmChatcommand("@", "/setmyskill 'piercing mastery' 100");
	
	cmChatcommand("@", "/setmyskill 'warrior' 100");
	cmChatcommand("@", "/setmyskill 'demolition' 100");
	cmChatcommand("@", "/setmyskill 'two-handed axes mastery' 100");
	cmChatcommand("@", "/setmyskill 'two-handed blunt mastery' 100");
	cmChatcommand("@", "/setmyskill 'two-handed blades mastery' 100");
	cmChatcommand("@", "/setmyskill 'war cries' 100");
	cmChatcommand("@", "/setmyskill 'crossbows mastery' 100");
	cmChatcommand("@", "/setmyskill 'bows mastery' 100");
	cmChatcommand("@", "/setmyskill 'combat preparation' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function armor(){
	// Sets armor skills
	echo("********************************************");
	echo("");
	echo("## Setting all armor skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'chainmail armors' 100");
	cmChatcommand("@", "/setmyskill 'scale armors' 100");
	cmChatcommand("@", "/setmyskill 'plate armors' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function special(){
	// set optional combat skills.
	echo("********************************************");
	echo("");
	echo("## Setting optional combat skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'equipment maintain' 100");
	cmChatcommand("@", "/setmyskill 'battle survival' 100");
	cmChatcommand("@", "/setmyskill 'drill' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function crafting(){
	// Sets all craftings kills
	echo("********************************************");
	echo("");
	echo("## Setting all crafting skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'artisan' 100");
	cmChatcommand("@", "/setmyskill 'carpentry' 100");
	cmChatcommand("@", "/setmyskill 'bowcraft' 100");
	cmChatcommand("@", "/setmyskill 'warfare engineering' 100");
	cmChatcommand("@", "/setmyskill 'construction' 100");
	cmChatcommand("@", "/setmyskill 'masonry' 100");
	cmChatcommand("@", "/setmyskill 'architecture' 100");
	cmChatcommand("@", "/setmyskill 'building maintain' 100");
	cmChatcommand("@", "/setmyskill 'digging' 100");
	cmChatcommand("@", "/setmyskill 'mining' 100");
	cmChatcommand("@", "/setmyskill 'precious prospecting' 100");
	cmChatcommand("@", "/setmyskill 'jewelry' 100");
	cmChatcommand("@", "/setmyskill 'materials preparation' 100");
	cmChatcommand("@", "/setmyskill 'smelting' 100");
	cmChatcommand("@", "/setmyskill 'forging' 100");
	cmChatcommand("@", "/setmyskill 'armorsmithing' 100");
	
	cmChatcommand("@", "/setmyskill 11 100");
	cmChatcommand("@", "/setmyskill 'herbalism' 100");
	cmChatcommand("@", "/setmyskill 'healing' 100");
	cmChatcommand("@", "/setmyskill 'alchemy' 100");
	cmChatcommand("@", "/setmyskill 'farming' 100");
	cmChatcommand("@", "/setmyskill 'forestry' 100");
	cmChatcommand("@", "/setmyskill 'advanced farming' 100");
	cmChatcommand("@", "/setmyskill 'brewing' 100");
	cmChatcommand("@", "/setmyskill 'cooking' 100");
	
	cmChatcommand("@", "/setmyskill 'hunting' 100");
	cmChatcommand("@", "/setmyskill 'animal lore' 100");
	cmChatcommand("@", "/setmyskill 'procuration' 100");
	cmChatcommand("@", "/setmyskill 'warhorse training' 100");
	cmChatcommand("@", "/setmyskill 'tailoring' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function minor(){
	// sets minor skills
	echo("********************************************");
	echo("");
	echo("## Setting all minor skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'authority' 100");
	cmChatcommand("@", "/setmyskill 'movement' 100");
	cmChatcommand("@", "/setmyskill 'general actions' 100");
	cmChatcommand("@", "/setmyskill 'horseback riding' 100");
	cmChatcommand("@", "/setmyskill 'swimming' 100");
	cmChatcommand("@", "/setmyskill 'piety' 100");
	cmChatcommand("@", "/setmyskill 'mentoring' 100");
	cmChatcommand("@", "/setmyskill 'arts' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function maxskills() {
	// gives player all skills
	echo("********************************************");
	echo("");
	echo("## Setting all skills to 100 ##");
	echo("");
	echo("********************************************");
	combat();
	wait(500);
	armor();
	wait(500);
	special();
	wait(500);
	minor();
	wait(500);
	crafting();
}

function alignment(){
	// Sets alignment to 1000
	echo("********************************************");
	echo("## Setting alignment to 10000 ##");
	echo("********************************************");
	cmChatCommand('@', "/ALIGNMENT 1000");
}

function newplayer(){
	// Setup a new player
	maxskills();
	wait(1000);
	alignment();
}
	cmChatcommand("@", "/setmyskill 'war cries' 100");
	cmChatcommand("@", "/setmyskill 'crossbows mastery' 100");
	cmChatcommand("@", "/setmyskill 'bows mastery' 100");
	cmChatcommand("@", "/setmyskill 'combat preparation' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function armor(){
	// Sets armor skills
	echo("********************************************");
	echo("");
	echo("## Setting all armor skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'chainmail armors' 100");
	cmChatcommand("@", "/setmyskill 'scale armors' 100");
	cmChatcommand("@", "/setmyskill 'plate armors' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function special(){
	// set optional combat skills.
	echo("********************************************");
	echo("");
	echo("## Setting optional combat skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'equipment maintain' 100");
	cmChatcommand("@", "/setmyskill 'battle survival' 100");
	cmChatcommand("@", "/setmyskill 'drill' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function crafting(){
	// Sets all craftings kills
	echo("********************************************");
	echo("");
	echo("## Setting all crafting skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'artisan' 100");
	cmChatcommand("@", "/setmyskill 'carpentry' 100");
	cmChatcommand("@", "/setmyskill 'bowcraft' 100");
	cmChatcommand("@", "/setmyskill 'warfare engineering' 100");
	cmChatcommand("@", "/setmyskill 'construction' 100");
	cmChatcommand("@", "/setmyskill 'masonry' 100");
	cmChatcommand("@", "/setmyskill 'architecture' 100");
	cmChatcommand("@", "/setmyskill 'building maintain' 100");
	cmChatcommand("@", "/setmyskill 'digging' 100");
	cmChatcommand("@", "/setmyskill 'mining' 100");
	cmChatcommand("@", "/setmyskill 'precious prospecting' 100");
	cmChatcommand("@", "/setmyskill 'jewelry' 100");
	cmChatcommand("@", "/setmyskill 'materials preparation' 100");
	cmChatcommand("@", "/setmyskill 'smelting' 100");
	cmChatcommand("@", "/setmyskill 'forging' 100");
	cmChatcommand("@", "/setmyskill 'armorsmithing' 100");
	
	cmChatcommand("@", "/setmyskill 11 100");
	cmChatcommand("@", "/setmyskill 'herbalism' 100");
	cmChatcommand("@", "/setmyskill 'healing' 100");
	cmChatcommand("@", "/setmyskill 'alchemy' 100");
	cmChatcommand("@", "/setmyskill 'farming' 100");
	cmChatcommand("@", "/setmyskill 'forestry' 100");
	cmChatcommand("@", "/setmyskill 'advanced farming' 100");
	cmChatcommand("@", "/setmyskill 'brewing' 100");
	cmChatcommand("@", "/setmyskill 'cooking' 100");
	
	cmChatcommand("@", "/setmyskill 'hunting' 100");
	cmChatcommand("@", "/setmyskill 'animal lore' 100");
	cmChatcommand("@", "/setmyskill 'procuration' 100");
	cmChatcommand("@", "/setmyskill 'warhorse training' 100");
	cmChatcommand("@", "/setmyskill 'tailoring' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function minor(){
	// sets minor skills
	echo("********************************************");
	echo("");
	echo("## Setting all minor skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'authority' 100");
	cmChatcommand("@", "/setmyskill 'movement' 100");
	cmChatcommand("@", "/setmyskill 'general actions' 100");
	cmChatcommand("@", "/setmyskill 'horseback riding' 100");
	cmChatcommand("@", "/setmyskill 'swimming' 100");
	cmChatcommand("@", "/setmyskill 'piety' 100");
	cmChatcommand("@", "/setmyskill 'mentoring' 100");
	cmChatcommand("@", "/setmyskill 'arts' 100");
	echo("********************************************");
	echo("Done");
	echo("********************************************");
}

function maxskills() {
	// gives player all skills
	echo("********************************************");
	echo("");
	echo("## Setting all skills to 100 ##");
	echo("");
	echo("********************************************");
	combat();
	wait(500);
	armor();
	wait(500);
	special();
	wait(500);
	minor();
	wait(500);
	crafting();
}

function alignment(){
	// Sets alignment to 1000
	echo("********************************************");
	echo("## Setting alignment to 10000 ##");
	echo("********************************************");
	cmChatCommand('@', "/ALIGNMENT 1000");
}

function newplayer(){
	// Setup a new player
	maxskills();
	wait(1000);
	alignment();
}