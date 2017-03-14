function heal()
{
	echo("## You are being healed! ##");
	cmChatCommand('@', "/removeeffects");
	wait(1000);
	cmChatCommand('@', "/healself");
	cmChatCommand("", "<color:ff0000>I've healed.");
}

// bind key to
GlobalActionMap.bindCmd(keyboard, "alt h", "heal();");