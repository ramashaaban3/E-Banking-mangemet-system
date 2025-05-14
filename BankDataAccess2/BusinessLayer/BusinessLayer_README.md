# 📘 Business Layer - ReadMe

Bu doküman, Online Banking Management System projesinin İş Mantığı Katmanı (Business Layer) içeriğini açıklamaktadır. Her bir manager sınıfının sorumlulukları, ilgili form arayüzlerinin yapısı ve sistemdeki etkileşimler açıklanmıştır.

---

## 🔹 UserManager & UserManagerTest.cs

**Açıklama:** Kullanıcı kayıt ve giriş işlemlerinin doğrulama ve yönetimini sağlar.

### 🛠️ Sınıf Sorumlulukları
- Yeni kullanıcı kayıt işlemi (Register)
- Giriş işlemi doğrulama (Login)
- Şifre uzunluğu kontrolü (minimum 6 karakter)
- Kullanıcı adı veya ad-soyad tekrarını engeller

### 🖼️ Form Arayüz Detayları
1. Ad Soyad, Kullanıcı Adı ve Şifre alanları
2. Giriş Yap ve Kayıt Ol butonları
3. Kayıt sonrası kullanıcıların listelenmesi
4. Şifre alanı altında uyarı etiketi

### 🔁 Veritabanı Etkileşimleri
- Users tablosuna INSERT işlemi
- Girişte SELECT ile doğrulama

### 📝 Loglama Bilgisi
- Başarılı kayıt ve giriş işlemleri loglanır
- Hatalı girişler özel log mesajları içerir

---

## 🔹 ClientManager & ClientManagerTest.cs

**Açıklama:** Müşteri bilgilerini (ClientName, Phone) veritabanına kaydeder ve yönetir.

### 🛠️ Sınıf Sorumlulukları
- Yeni müşteri ekleme (AddClient)
- Müşteri güncelleme (UpdateClient)
- Müşteri silme (DeleteClient)

### 🖼️ Form Arayüz Detayları
1. Ad Soyad ve Telefon alanları
2. Müşteri Ekle, Güncelle, Sil butonları
3. Seçilen müşterinin otomatik doldurulması
4. ListBox ile tüm müşterilerin listelenmesi

### 🔁 Veritabanı Etkileşimleri
- Clients tablosuna INSERT, UPDATE, DELETE işlemleri

### 📝 Loglama Bilgisi
- Her işlem sonucunda uygun log mesajı kaydedilir

---

## 🔹 AccountManager & AccountManagerTest.cs

**Açıklama:** Hesap açma, kapama, para yatırma ve çekme işlemlerini gerçekleştirir.

### 🛠️ Sınıf Sorumlulukları
- Hesap açma (OpenAccount)
- Para yatırma (DepositMoney)
- Para çekme (WithdrawMoney)
- Hesap kapatma (CloseAccount)

### 🖼️ Form Arayüz Detayları
1. Müşteri ID, Hesap ID, Tutar alanları
2. Hesap Aç, Kapat, Para Yatır, Para Çek butonları
3. Hesap listesi ListBox’ta gösterilir

### 🔁 Veritabanı Etkileşimleri
- Accounts tablosuna INSERT, UPDATE, DELETE işlemleri

### 📝 Loglama Bilgisi
- Tüm işlemler detaylı şekilde loglanır

---

## 🔹 TransactionManager & TransactionManagerTest.cs

**Açıklama:** Hesaplar arasında para transferi yapar ve işlem geçmişi listeler.

### 🛠️ Sınıf Sorumlulukları
- TransferMoney: Hesaplar arası para aktarımı
- GetTransactionHistory: Belirli hesap geçmişi

### 🖼️ Form Arayüz Detayları
1. Gönderen ve Alıcı Hesap ID, Tutar ve Geçmiş için Hesap ID
2. Transfer ve Hesap Geçmişi butonları
3. ListBox ile işlem geçmişi gösterilir

### 🔁 Veritabanı Etkileşimleri
- Transactions tablosuna INSERT yapılır
- Hesaplar güncellenir

### 📝 Loglama Bilgisi
- Başarılı ve hatalı transfer durumları loglanır

---

## 🔹 LogManager

**Açıklama:** Sistem genelinde önemli olayları Logs tablosuna yazar.

### 🛠️ Sınıf Sorumlulukları
- InsertLog: Metin ve tarih bilgisiyle kayıt ekler

### 🔁 Veritabanı Etkileşimleri
- Logs tablosuna INSERT

### 📝 Loglama Bilgisi
- Tüm modüllerdeki önemli olaylar buraya yazılır

---

## 🧑 Hazırlayan: İbrahim SEYREK 