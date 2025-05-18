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

namespace BankDataAccess2.Entities
{
    public partial class AccountForm: Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

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

        private void btnAddAccount_MouseEnter(object sender, EventArgs e)
        {
            btnAddAccount.BackColor = Color.RoyalBlue;
        }
        private void btnAddAccount_MouseLeave(object sender, EventArgs e)
        {
            btnAddAccount.BackColor = ColorTranslator.FromHtml("#007ACC");
        }


        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClientID.Text, out int clientId) ||
                !decimal.TryParse(txtBalance.Text, out decimal balance))
            {
                MessageBox.Show("Geçersiz giriş.");
                return;
            }

            try
            {
                AccountDataAccess.InsertAccount(clientId, balance);
                MessageBox.Show("Hesap başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnListAccounts_Click(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();

            try
            {
                var accounts = AccountDataAccess.GetAllAccounts();
                foreach (var acc in accounts)
                    lstAccounts.Items.Add(acc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplar alınamadı: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
