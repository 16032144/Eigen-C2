<?php

$mysql = mysqli_connect("localhost", "root", "root", "ControlPanel");

if(mysqli_connect_errno())
{
	echo "Failed to connect database: " . mysqli_connect_errno();
	exit;
}
?>


