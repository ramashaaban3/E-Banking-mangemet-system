# Online Banking Management System
Bu proje, C# ve .NET ile geliştirilen bir çevrim içi banka yönetim sistemidir.

## Özellikler
- Kullanıcı girişi ve kayıt
- Para yatırma ve çekme
- Yönetici kontrol paneli

  # 💳 Online Bankacılık Yönetim Sistemi - Veri Erişim Katmanı (DataAccess Layer)

Bu proje, C# (.NET Framework) kullanılarak geliştirilen bir online bankacılık sisteminin **veritabanı bağlantı ve veri erişim katmanıdır**.  
Kod, SQL Server veritabanı ile haberleşir ve aşağıdaki tablolar üzerinde tam CRUD işlemlerini sağlar:

- 👤 Users (Kullanıcılar)
- 👥 Clients (Müşteriler)
- 🏦 Accounts (Hesaplar)
- 📒 Logs (Kayıtlar / Olaylar)
- 💰 Transactions (İşlemler)

---

## 📌 Gereksinimler

- Visual Studio 2019 veya 2022
- .NET Framework 4.7.2
- SQL Server (MSSQLLocalDB)
- SQL Server Management Studio (SSMS) (tercihen)

---

## ⚙️ Veritabanı Kurulum Talimatları

1. SQL Server'ı açın 
2. SSMS (SQL Server Management Studio) üzerinden yeni bir veritabanı oluşturun:
   
BankDB
3. Aşağıdaki SQL komutlarını çalıştırarak tabloları oluşturun:

<details>
<summary>▶️ Tabloları göster</summary>

sql```
CREATE TABLE Users (
 UserID INT PRIMARY KEY IDENTITY(1,1),
 FullName NVARCHAR(100),
 Username NVARCHAR(50) ,
 Password NVARCHAR(50)
);

CREATE TABLE Clients (
 ClientID INT PRIMARY KEY IDENTITY(1,1),
 FullName NVARCHAR(100),
 Phone NVARCHAR(20)
);

CREATE TABLE Accounts (
 AccountID INT PRIMARY KEY IDENTITY(1,1),
 ClientID INT,
 Balance DECIMAL(18,2) DEFAULT 0,
 FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);

CREATE TABLE Logs (
 LogID INT PRIMARY KEY IDENTITY(1,1),
 LogMessage NVARCHAR(200),
 Date DATETIME DEFAULT GETDATE()
);

CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    SenderId INT NULL,
    ReceiverId INT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Date DATETIME DEFAULT GETDATE(),
    Description NVARCHAR(200) NULL
);


 </details>



  🧠 Kullanım
-UserDataAccess, ClientDataAccess, AccountDataAccess, LogsDataAccess, TransactionsDataAccess sınıfları her tablo için ayrı ayrı veri erişimi sağlar.

-Tüm sınıflar static olarak yazılmıştır ve doğrudan çağrılabilir.
  Örnek:
 UserDataAccess.InsertUser("Ali Veli", "aliveli", "1234");
 var users = UserDataAccess.GetAllUsers();

 Hazırlayan: Rama SHAABAN :)





 ---Görev 3---
 
👤🔐LoginForm

LoginForm, kullanıcının sisteme giriş yapmasını sağlayan ilk formdur.Kullanıcı adı ve şifre bilgisi girilerek, sistemde kayıtlı kullanıcı bilgileriyle doğrulama yapılır.

☑Yapılanlar:
-Kullanıcının Username ve Password girişi sağlandı.
-UserDataAccess.GetUserByUsername(username) fonksiyonu ile veritabanından kullanıcı bilgisi çekildi.
-Giriş başarılıysa sistemde sonraki forma (ClientForm) yönlendirme yapıldı.
-Hatalı girişlerde bilgilendirici mesaj kutuları eklendi.

 
Kullanılan Teknolojiler:
  C# (.NET Framework)
  Windows Forms
  SQL Server (LocalDB)
  ADO.NET ile veritabanı bağlantısı

Projedeki Katmanı:
Entities (UI) katmanında yer alır.
Arka planda DataAccess katmanı ile iletişim kurar.


👥ClientForm

ClientForm, sistemdeki müşterilerin eklenmesini, güncellenmesini, silinmesini ve aranmasını sağlar.

☑Yapılanlar:
-txtClientName ve txtPhone aracılığıyla kullanıcıdan veri alındı.
-ClientManager aracılığıyla Add, Update, Delete, Get işlemleri sağlandı.
-ListBox kontrolüyle sistemdeki tüm müşteriler listelendi.
-Arama butonu ile isim bazlı müşteri sorgulama gerçekleştirildi.
-Butonlara hover (üzerine gelince renk değişimi) efektleri eklendi.

Kullanılan Teknolojiler:
  C# (.NET Framework)
  Windows Forms
  SQL Server (LocalDB)
  Katmanlı Mimari
  ADO.NET

Projedeki Katmanı:
Entities (UI) katmanında yer alır.
İş mantığı BusinessLayer üzerinden, veri erişimi ise DataAccess katmanı ile sağlanır.



👤AccountForm

AccountForm, müşteri hesaplarının oluşturulmasını, silinmesini, bakiye güncellemelerini (yatırma/çekme) ve listelemeyi sağlar.

☑Yapılanlar:
-txtClientID, txtAccountID, txtAmount alanları ile kullanıcı girişi sağlandı.
-Yeni hesap ekleme, hesap silme, para yatırma ve çekme işlemleri eklendi.
-ListBox ile tüm hesaplar listelendi.
-Her işlem sonrası btnListAccounts_Click çağrılarak anlık güncel liste sağlandı.

Kullanılan Teknolojiler:
  C# (.NET Framework)
  Windows Forms
  SQL Server (LocalDB)
  ADO.NET (Manual SQL Queries)

Projedeki Katmanı:
Entities (UI) katmanında bulunur.
İşlem mantığı AccountDataAccess sınıfı üzerinden veritabanı ile etkileşim kurar.



📲💰🔁TransactionForm

TransactionForm, hesaplar arası para transferi yapmayı ve belirli bir hesaba ait işlem geçmişini görüntülemeyi sağlar.

☑Yapılanlar:
-txtSenderAccount, txtReceiverAccount, txtAmount, txtDescription alanları kullanılarak transfer gerçekleştirildi.
-TransactionManager.TransferMoney() ile işlem sırasıyla Withdraw, Deposit ve InsertTransaction adımlarını takip etti.
-Transfer işleminden sonra açıklama (description) ve işlem tarihiyle birlikte veritabanına kayıt yapıldı.
-btnListTransactions_Click ile belirli bir hesap için işlem geçmişi getirildi.

Kullanılan Teknolojiler:
  C# (.NET Framework)
  Windows Forms
  SQL Server (LocalDB)
  ADO.NET
  Katmanlı mimari
  Exception ve loglama yönetimi

Projedeki Katmanı:
Entities (UI) katmanında bulunur.
İş mantığı TransactionManager (BusinessLayer) sınıfında tanımlıdır.
Veri işlemleri AccountDataAccess ve TransactionsDataAccess üzerinden yürütülür.
