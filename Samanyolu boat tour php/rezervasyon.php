<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $tarih = $_POST['tarih'];
    $tekne = $_POST['tekne'];
    $tur_turu = $_POST['tour-type'];
    $kisi_sayisi = $_POST['people'];

    require 'db.php';

    try {
        $stmt = $conn->prepare("INSERT INTO rezervasyonlar (tarih, tekne, tur_turu, kisi_sayisi) VALUES (?, ?, ?, ?)");
        
        $stmt->execute([$tarih, $tekne, $tur_turu, $kisi_sayisi]);
        
        header("Location: index.php?success=1");
        exit();
    } catch (PDOException $e) {
        header("Location: index.php");
    }
}

$sql = "SELECT tarih FROM rezervasyonlar";
$stmt = $conn->query($sql);
$rezervasyonlar = $stmt->fetchAll(PDO::FETCH_COLUMN);

$tarihVerileri = [];
foreach ($rezervasyonlar as $rezervasyon) {
    $tarihVerileri[$rezervasyon] = 'dolu';
}

?>
