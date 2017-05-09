function combat(){
	// Sets combat skills
	echo("********************************************");
	echo("");
	echo("## Setting all combat skills to 100 ##");
	echo("");
	echo("********************************************");
	cmChatcommand("@", "/setmyskill 'Milita' 100");
	cmChatcommand("@", "/setmyskill 'Slinger' 100");
	cmChatcommand("@", "/setmyskill 'Cavalryman' 100");
	cmChatcommand("@", "/setmyskill 'Knight' 100");
	cmChatcommand("@", "/setmyskill 'Lancer' 100");
	cmChatcommand("@", "/setmyskill 'Spearman' 100");
	cmChatcommand("@", "/setmyskill 'Guard' 100");
	cmChatcommand("@", "/setmyskill 'Footman' 100");
	cmChatcommand("@", "/setmyskill 'Swordsman' 100");
	cmChatcommand("@", "/setmyskill 'Huskarl' 100");
	
	cmChatcommand("@", "/setmyskill 'Archer' 100");
	cmChatcommand("@", "/setmyskill 'demolition' 100");
	cmChatcommand("@", "/setmyskill 'Ranger' 100");
	cmChatcommand("@", "/setmyskill 'Assaulter' 100");
	cmChatcommand("@", "/setmyskill 'Vanguard' 100");
	cmChatcommand("@", "/setmyskill 'Berserker' 100");
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

function ella() {
	cmChatcommand("@", "/setmyskill 'poleaxes mastery' 90");
	cmChatcommand("@", "/setmyskill 'piercing mastery' 90");
	cmChatcommand("@", "/setmyskill 'lancing' 90");
	cmChatcommand("@", "/setmyskill 'chainmail armors' 90");
	cmChatcommand("@", "/setmyskill 'mounted fighting mastery' 90");
}
