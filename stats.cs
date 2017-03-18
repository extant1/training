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
