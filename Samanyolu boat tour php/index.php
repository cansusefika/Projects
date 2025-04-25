<?php require 'db.php'; ?>


<!DOCTYPE html>
<html lang="tr">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Samanyolu Boat Tour</title>
  <link rel="stylesheet" href="style.css">
</head>
<body>
  
  <header>
    <div class="container">
      <a href="index.php" class="logo">
        <img src="logo.jpg" alt="Samanyolu Boat Tour Logo" class="circular-logo">
      </a>
      
      <nav class="navbar">
        <ul>
          <li><a href="#home">Ana Sayfa</a></li>
          <li><a href="#services">Hizmetlerimiz</a></li>
          <li><a href="#rezervasyonlar">Rezervasyon</a></li>
          <li><a href="hakkimizda.html">Hakkımızda</a></li>
          <li><a href="#iletisim">İletişim</a></li>
        </ul>
      </nav>
    </div>
  </header>

  <section id="home">
    <h1>Samanyolu Boat Tour</h1>
    <p>Eşsiz deniz deneyimleri ve unutulmaz anlar için bizimle yelken açın!</p>
    <video width="640" height="360" controls autoplay muted loop>
        <source src="WhatsApp Video 2024-07-17 saat 00.06.12_f6c6b8c8.mp4" type="video/mp4">
    </video>
  </section>

  <section id="services" class="services-section">
    <h2>Hizmetlerimiz</h2>
    <div class="services-container">
      <div class="service-card">
        <h3>Zengin Menü</h3>
        <p>Teknemizde sizlere zengin bir menü seçeneği sunuyoruz. Lezzetli yemeklerimizle deniz keyfinizi tamamlıyoruz.</p>
      </div>
      <div class="service-card">
        <h3>Müzik</h3>
        <p>Teknemizde keyifli bir atmosfer için müzik sistemi bulunmaktadır. İstediğiniz müzikleri dinleyebilir ve eğlencenin tadını çıkarabilirsiniz.</p>
      </div>
      <div class="service-card">
        <h3>Wi-Fi</h3>
        <p>Teknemizde ücretsiz Wi-Fi erişimi bulunmaktadır. İnternet bağlantısı sayesinde haberleri takip edebilir veya sosyal medyada vakit geçirebilirsiniz.</p>
      </div>
      <div class="service-card">
        <h3>Eksiksiz Donanım</h3>
        <p>Teknemizde ihtiyacınız olan her türlü donanım bulunmaktadır. Güvenliğiniz ve konforunuz için eksiksiz bir donanım sunuyoruz.</p>
      </div>
    </div>
  </section>

  <section id="rezervasyonlar" class="reservation-section">
    <h2>Rezervasyon</h2>
    <?php if (isset($rezervasyon_basarili) && $rezervasyon_basarili): ?>
    <div class="success-message">
        <p>Rezervasyonunuz başarıyla alındı! Teşekkür ederiz.</p>
    </div>
<?php elseif (isset($rezervasyon_basarili) && !$rezervasyon_basarili): ?>
    <div class="error-message">
        <p>Rezervasyonunuz alınırken bir hata oluştu. Lütfen tekrar deneyin.</p>
    </div>
<?php endif; ?>

    <div class="calendar">
        <?php
        
        $gunler = ['Pzt', 'Sal', 'Çar', 'Per', 'Cum', 'Cmt', 'Paz'];
        foreach ($gunler as $gun) {
            echo "<div class='day'>$gun</div>";
        }
    
        for ($i = 1; $i <= 30; $i++) {
            $tarih = date('Y-m') . '-' . str_pad($i, 2, '0', STR_PAD_LEFT);
            $durum = $tarihVerileri[$tarih] ?? 'uygun';
            $class = $durum === 'dolu' ? 'booked' : 'available';
    
            echo "<div class='day $class' title='" . ucfirst($durum) . "'>$i</div>";
        }
        ?>
    </div>
    
    <form action="rezervasyon.php" method="POST">
        <label for="tarih">Tarih:</label>
        <input type="date" id="tarih" name="tarih" required>
        
        <label for="tekne">Tekne Seçin:</label>
        <select id="tekne" name="tekne" required>
            <option value="Tekne 1">Samanyolu 1</option>
            <option value="Tekne 2">Samanyolu 3</option>
        </select>
        
        <label for="tour-type">Tur Türü Seçin:</label>
        <select id="tour-type" name="tour-type" required>
            <option value="sailing">Özel gün Tur</option>
            <option value="fishing">Balık Tutma Tur</option>
            <option value="daily">Günlük Gezi</option>
            <option value="sunset">Gün Batımı Turu</option>
        </select>

        <label for="people">Kaç Kişi:</label>
        <input type="number" id="people" name="people" min="1" max="50" required>
        
        <button type="submit">Rezervasyon Yap</button>
    </form>
  </section>

  <section id="iletisim">
    <h2>Bizimle İletişime Geçin</h2>
    <p>Her türlü soru, görüş veya öneriniz için bize ulaşabilirsiniz.</p>
    
    <div class="contact-container">
      <div class="contact-info">
        <h3>İletişim Bilgileri</h3>
        <p><strong>Adres:</strong> İzmir, Türkiye</p>
        <p><strong>Telefon:</strong> 0546 945 44 40</p>
        <p><strong>E-posta:</strong> samanyoluboattour@gmail.com</p>
        <p><strong>Çalışma Saatleri:</strong> Haftanın her günü</p>
        
        <div class="social-media">
          <a href="https://www.instagram.com" target="_blank" class="social-btn instagram">Instagram</a>
          <a href="https://wa.me/905469454440" target="_blank" class="social-btn whatsapp">WhatsApp</a>
        </div>
      </div>

      <div class="contact-form">
  <h3>Bize Yazın</h3>
  <form action="iletisim.php" method="POST">
  <label for="name">Adınız:</label>
    <input type="text" id="name" name="name" required>  

    <label for="email">E-Posta:</label>
    <input type="email" id="email" name="email" required>  

    <label for="message">Mesajınız:</label>
    <textarea id="message" name="message" rows="4" required></textarea> 

    <button type="submit">Gönder</button> 
  </form>
</div>

    </div>
  </section>
  
  <footer>
    <p>SIĞACIK SAMANYOLU TEKNE TURU</p>
    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3135.6391491796835!2d26.781199475713702!3d38.19505537188252!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14bb8dbffc082a6d%3A0xffed4637935a50f0!2sSI%C4%9EACIK%20SAMANYOLU%20TEKNE%20TURU!5e0!3m2!1str!2str!4v1734473171990!5m2!1str!2str" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
  </footer>
</body>
</html>
