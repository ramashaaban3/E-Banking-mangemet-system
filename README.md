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
- SQL Server (Express veya Developer Edition)
- SQL Server Management Studio (SSMS) (tercihen)

---

## ⚙️ Veritabanı Kurulum Talimatları

1. SQL Server'ı açın (örnek: `RAMASHAABAN\SQLEXPRESS` gibi)
2. SSMS (SQL Server Management Studio) üzerinden yeni bir veritabanı oluşturun:
   
BankDB
3. Aşağıdaki SQL komutlarını çalıştırarak tabloları oluşturun:

<details>
<summary>▶️ Tabloları göster</summary>

sql```
CREATE TABLE Users (
 UserID INT PRIMARY KEY IDENTITY(1,1),
 FullName NVARCHAR(100),
 Username NVARCHAR(50) UNIQUE,
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
 Message NVARCHAR(200),
 Date DATETIME DEFAULT GETDATE()
);

CREATE TABLE Transactions (
 TransactionID INT PRIMARY KEY IDENTITY(1,1),
 AccountID INT,
 Amount DECIMAL(18,2),
 Type NVARCHAR(20),
 Date DATETIME DEFAULT GETDATE(),
 FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);
 </details>

🔌 App.config Bağlantı Ayarı
Veritabanına bağlanmak için App.config dosyasındaki bağlantı cümlesi güncellenmelidir:

<connectionStrings>
  <add name="BankDBConnection"
       connectionString="Server=PC_ADINIZ\\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
  Not: PC_ADINIZ\\SQLEXPRESS kısmını kendi bilgisayar adınıza göre düzenleyin.

  🧠 Kullanım
-UserDataAccess, ClientDataAccess, AccountDataAccess, LogsDataAccess, TransactionsDataAccess sınıfları her tablo için ayrı ayrı veri erişimi sağlar.

-Tüm sınıflar static olarak yazılmıştır ve doğrudan çağrılabilir.
  Örnek:
 UserDataAccess.InsertUser("Ali Veli", "aliveli", "1234");
 var users = UserDataAccess.GetAllUsers();

 Hazırlayan: Rama SHAABAN :)
 

 

 
