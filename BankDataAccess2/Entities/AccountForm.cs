using BankDataAccess2.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankDataAccess2.DataAccess;

namespace BankDataAccess2.Entities
{
    public partial class AccountForm: Form
    {
        // Formun constructor'ı. Form yüklendiğinde arayüz bileşenlerini başlatır.
        public AccountForm()
        {
            InitializeComponent();
        }


        private void AccountForm_Load(object sender, EventArgs e)
        {

        }
        // Hesap nesnesi için yardımcı sınıf
        public class Account
        {
            public int AccountID { get; set; }
            public int ClientID { get; set; } // Foreign key
            public string AccountType { get; set; }
            public decimal Balance { get; set; }
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        // Ekle butonuna mouse gelince arka plan rengi değişir.
        private void btnAddAccount_MouseEnter(object sender, EventArgs e)
        {
            btnAddAccount.BackColor = Color.RoyalBlue;
        }

        // Mouse ayrıldığında varsayılan renge döner.
        private void btnAddAccount_MouseLeave(object sender, EventArgs e)
        {
            btnAddAccount.BackColor = ColorTranslator.FromHtml("#007ACC");
        }

        // Yeni hesap ekleme işlemi
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan değerler parse ediliyor
            if (!int.TryParse(txtClientID.Text, out int clientId) ||
                !decimal.TryParse(txtAmount.Text.Trim(), out decimal balance))
            {
                MessageBox.Show("Geçerli müşteri no ve bakiye girin.");
                return;
            }

            try
            {
                // Veritabanına hesap eklenir
                AccountDataAccess.InsertAccount(clientId, balance);
                MessageBox.Show("Hesap başarıyla eklendi.");
                btnListAccounts_Click(null, null);        // Liste güncellenir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Tüm hesapları listeler
        private void btnListAccounts_Click(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();            // Liste temizlenir
            var accounts = AccountDataAccess.GetAllAccounts();        // Hesaplar alınır
            foreach (var acc in accounts)
            {
                lstAccounts.Items.Add(acc);                        // Listeye eklenir
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Hesap silme işlemi
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountID.Text.Trim(), out int accountId))
            {
                MessageBox.Show("Geçerli hesap no girin.");
                return;
            }

            try
            {
                AccountDataAccess.DeleteAccount(accountId);
                MessageBox.Show("Hesap silindi.");
                btnListAccounts_Click(null, null);        // Liste güncellenir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Para yatırma işlemi
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountID.Text.Trim(), out int accountId) ||
                !decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("Geçerli hesap no ve tutar girin.");
                return;
            }

            try
            {
                AccountDataAccess.Deposit(accountId, amount);
                MessageBox.Show("Para yatırıldı.");
                btnListAccounts_Click(null, null);        // Liste güncellenir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Para çekme işlemi
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountID.Text.Trim(), out int accountId) ||
                !decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("Geçerli hesap no ve tutar girin.");
                return;
            }

            try
            {
                AccountDataAccess.Withdraw(accountId, amount);
                MessageBox.Show("Para çekildi.");
                btnListAccounts_Click(null, null);            // Liste güncellenir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
