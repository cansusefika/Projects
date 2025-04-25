<?php

//Email information

$name = $_POST["name"];
$email = $_POST["Email"];
$subject = $_POST["msg_subject"];
$content = $_POST["message"];
$to = "cansusefikaculhaa@gmail.com";
$mailHeaders = "From: " . $name . "<" . $email . ">\r\n";
mail($to, $subject, $content, $mailHeaders);
header("Location:index.html");
?>