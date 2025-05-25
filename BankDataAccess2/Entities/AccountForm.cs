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
                !decimal.TryParse(txtAmount.Text.Trim(), out decimal balance))
            {
                MessageBox.Show("Geçerli müşteri no ve bakiye girin.");
                return;
            }

            try
            {
                AccountDataAccess.InsertAccount(clientId, balance);
                MessageBox.Show("Hesap başarıyla eklendi.");
                btnListAccounts_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnListAccounts_Click(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();
            var accounts = AccountDataAccess.GetAllAccounts();
            foreach (var acc in accounts)
            {
                lstAccounts.Items.Add(acc);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

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
                btnListAccounts_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

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
                btnListAccounts_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

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
                btnListAccounts_Click(null, null);
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
