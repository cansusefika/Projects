<?php
// Formdan gelen verileri al
$name = $_POST["name"];
$phonenumber = $_POST["tel"];
$email = $_POST["Email"];
$subject = $_POST["msg_subject"];
$content = $_POST["message"];

// E-posta başlığı oluştur
$to = "nehirrunalann@gmail.com";
$mailHeaders = "From: " . $name . " <" . $email . ">\r\n";
$mailHeaders .= "Reply-To: " . $email . "\r\n";
$mailHeaders .= "MIME-Version: 1.0\r\n";
$mailHeaders .= "Content-Type: text/plain; charset=utf-8\r\n";

// E-postayı gönder
if (mail($to, $subject, $content, $mailHeaders)) {
    header("Location: my.html");
    exit;
} else {
    echo "E-posta gönderilirken bir hata oluştu.";
}
?>



