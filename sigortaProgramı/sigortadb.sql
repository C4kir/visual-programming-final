-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 01 Oca 2023, 11:13:04
-- Sunucu sürümü: 8.0.28
-- PHP Sürümü: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `sigortadb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kayit`
--

CREATE TABLE `kayit` (
  `kayit_id` int NOT NULL,
  `kullanici_adi` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `kullanici_sifre` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kayit`
--

INSERT INTO `kayit` (`kayit_id`, `kullanici_adi`, `kullanici_sifre`) VALUES
(15, 'a', '1'),
(16, 'ahmetcakir', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri`
--

CREATE TABLE `musteri` (
  `musteri_id` int NOT NULL,
  `musteri_adsoyad` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `musteri_tel` varchar(11) COLLATE utf8mb4_turkish_ci NOT NULL,
  `musteri_adres` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `musteri`
--

INSERT INTO `musteri` (`musteri_id`, `musteri_adsoyad`, `musteri_tel`, `musteri_adres`) VALUES
(6, 'Ahmet Çakır', '05555555555', 'Kütahya'),
(8, 'Banu Türk', '05666666667', 'İzmir'),
(9, 'Sude Güner', '0222555', 'Manisa'),
(11, 'Mehmet Sucu', '01111111112', 'Bursa'),
(13, 'Murat Bayrak', '06666666666', 'İzmit'),
(15, 'Burak Kurt', '02225556622', 'Bursa'),
(16, 'Dilek Tanrıkulu', '05458889966', 'Ankara');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `police`
--

CREATE TABLE `police` (
  `police_id` int NOT NULL,
  `musteri` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sirket_ismi` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sigorta_turu` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `police_baslangic` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `police_bitis` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `police_fiyat` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `police`
--

INSERT INTO `police` (`police_id`, `musteri`, `sirket_ismi`, `sigorta_turu`, `police_baslangic`, `police_bitis`, `police_fiyat`) VALUES
(6, 'Sude Güneri', 'Anadolu', 'Sağlık', '12', '12', 12),
(8, 'Murat Bayrak', 'Anadolu', 'Ulaşım', '31.12.2022', '31.12.2023', 550),
(9, 'Burak Kurt', 'Acı Badem', 'SağlıkSigortası', '12.12.2022', '12.12.2025', 970),
(10, 'Sude Güner', 'Acı Badem', 'Ulaşım', '12', '12', 1222),
(11, 'Ahmet Çakır', 'Acı Badem', 'Emlak', '123123123', '12312313', 123123123);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sigorta`
--

CREATE TABLE `sigorta` (
  `sigorta_id` int NOT NULL,
  `sigorta_turu` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `sigorta`
--

INSERT INTO `sigorta` (`sigorta_id`, `sigorta_turu`) VALUES
(7, 'Ev'),
(8, 'SağlıkSigortası'),
(9, 'Ulaşım'),
(10, 'Araba'),
(11, 'Emlak');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sirket`
--

CREATE TABLE `sirket` (
  `sirket_id` int NOT NULL,
  `sirket_ismi` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `sirket`
--

INSERT INTO `sirket` (`sirket_id`, `sirket_ismi`) VALUES
(6, 'HDI'),
(7, 'Anadolu'),
(8, 'Acı Badem'),
(9, 'Ak Sigorta'),
(10, 'Anadolu Sigorta');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kayit`
--
ALTER TABLE `kayit`
  ADD PRIMARY KEY (`kayit_id`);

--
-- Tablo için indeksler `musteri`
--
ALTER TABLE `musteri`
  ADD PRIMARY KEY (`musteri_id`);

--
-- Tablo için indeksler `police`
--
ALTER TABLE `police`
  ADD PRIMARY KEY (`police_id`);

--
-- Tablo için indeksler `sigorta`
--
ALTER TABLE `sigorta`
  ADD PRIMARY KEY (`sigorta_id`);

--
-- Tablo için indeksler `sirket`
--
ALTER TABLE `sirket`
  ADD PRIMARY KEY (`sirket_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kayit`
--
ALTER TABLE `kayit`
  MODIFY `kayit_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Tablo için AUTO_INCREMENT değeri `musteri`
--
ALTER TABLE `musteri`
  MODIFY `musteri_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Tablo için AUTO_INCREMENT değeri `police`
--
ALTER TABLE `police`
  MODIFY `police_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Tablo için AUTO_INCREMENT değeri `sigorta`
--
ALTER TABLE `sigorta`
  MODIFY `sigorta_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Tablo için AUTO_INCREMENT değeri `sirket`
--
ALTER TABLE `sirket`
  MODIFY `sirket_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
