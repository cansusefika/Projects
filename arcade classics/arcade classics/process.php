<?php
// PHPMailer kütüphanesini dahil edin
require 'vendor/autoload.php';

// PHPMailer ve Exception sınıflarını kullanacağımızı belirtiyoruz
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

// Formdan gelen verileri alıyoruz ve varsayılan olarak boş bir değer atıyoruz
$name = $_POST["contact_name"] ?? "";
$surname = $_POST["contact_surname"] ?? "";
$email = $_POST["contact_email"] ?? "";
$message = $_POST["contact_message"] ?? "";
$comment = $_POST["contact_comment"] ?? "";

// Alıcı e-posta adresini belirliyoruz
$to = "berkeekonomi@hotmail.com";

// E-posta başlığını tanımlıyoruz
$subject = "İletişim Formundan Yeni Mesaj";

// E-posta içeriğini oluşturuyoruz
$mailContent = "İsim: " . $name . "\n";
$mailContent .= "Soyisim: " . $surname . "\n";
$mailContent .= "E-posta: " . $email . "\n";
$mailContent .= "Mesaj: " . $message . "\n";
$mailContent .= "Siteye paylaşmak istedikleriniz: " . $comment . "\n";

// PHPMailer nesnesini oluşturuyoruz
$mail = new PHPMailer(true);

try {
    // SMTP'yi kullanacağımızı belirtiyoruz
    $mail->isSMTP();

    // SMTP sunucu adresini belirtiyoruz
    $mail->Host = 'smtp.office365.com';

    // SMTP kimlik doğrulamasını aktifleştiriyoruz
    $mail->SMTPAuth = true;

    // E-posta adresini ve şifresini belirtiyoruz
    $mail->Username = 'berkeekonomi@hotmail.com';
    $mail->Password = '123Ekonomi@';

    // Şifrelemenin TLS olduğunu belirtiyoruz
    $mail->SMTPSecure = 'tls';

    // SMTP port numarasını belirtiyoruz
    $mail->Port = 587;

    // E-posta gövdesinin dilini Türkçe olarak belirliyoruz
    $mail->setlanguage('tr');
    $mail->CharSet = 'UTF-8';

    // Gönderici bilgilerini belirtiyoruz
    $mail->setFrom('berkeekonomi@hotmail.com', 'berke deniz');

    // Alıcı adresini ekliyoruz
    $mail->addAddress($to);

    // E-posta konu ve içeriğini belirtiyoruz
    $mail->Subject = $subject;
    $mail->Body = $mailContent;

    // E-postayı gönderiyoruz
    $mail->send();
    echo 'E-posta başarıyla gönderildi.';
} catch (Exception $e) {
    echo 'E-posta gönderilirken bir hata oluştu: ' . $mail->ErrorInfo;
}

// Veritabanı bağlantısı için gerekli bilgileri belirtiyoruz
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "odev";

// MySQL veritabanına bağlanıyoruz
$conn = new mysqli($servername, $username, $password, $dbname);

// Bağlantı kontrolü yapılıyor
if ($conn->connect_error) {
    die("Veritabanına bağlanılamadı: " . $conn->connect_error);
}

// Veritabanına veri ekleme sorgusunu oluşturuyoruz
$sql = "INSERT INTO iletisim_formu (isim, soyisim, email, mesaj, yorum)
VALUES ('$name', '$surname', '$email', '$message', '$comment')";

// Sorguyu çalıştırıyoruz ve başarılıysa kullanıcıya mesaj veriyoruz
if ($conn->query($sql) === TRUE) {
    echo "Form başarıyla gönderildi!";
} else {
    // Hata oluşursa hatayı kullanıcıya gösteriyoruz
    echo "Hata oluştu: " . $sql . "<br>" . $conn->error;
}

// Veritabanı bağlantısını kapatıyoruz
$conn->close();

?>
