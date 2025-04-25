<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "tur_sitesi";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Veritabanı bağlantısı başarısız: " . $conn->connect_error);
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = isset($_POST["name"]) ? htmlspecialchars(trim($_POST["name"])) : null;
    $email = isset($_POST["email"]) ? filter_var(trim($_POST["email"]), FILTER_SANITIZE_EMAIL) : null;
    $subject = isset($_POST["msg_subject"]) ? htmlspecialchars(trim($_POST["msg_subject"])) : 'No Subject';
    $content = isset($_POST["message"]) ? htmlspecialchars(trim($_POST["message"])) : null;

    if (!$name || !$email || !$content) {
        echo "Lütfen tüm alanları doldurun.";
        exit();
    }

    $stmt = $conn->prepare("INSERT INTO iletisim (ad, email, konu, mesaj) VALUES (?, ?, ?, ?)");
    if ($stmt) {
        $stmt->bind_param("ssss", $name, $email, $subject, $content);

        if ($stmt->execute()) {
            header("Location: index.php?status=success");
            exit();
        } else {
            echo "Bir hata oluştu: " . $stmt->error;
        }

        $stmt->close();
    } else {
        echo "Sorgu hazırlama başarısız: " . $conn->error;
    }
}

$conn->close();
?>