using System;
using System.Windows.Forms;
using BusinessLayer;

namespace BankDataAccess2.BusinessLayer
{
    public partial class AccountManagerTest : Form
    {
        private IAccountService accountService = new AccountManager();
        public AccountManagerTest()
        {
            InitializeComponent();
            this.Text = "AccountManager Test Arayüzü";
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtClientID.Text.Trim(), out int clientId))
            {
                MessageBox.Show("Geçerli bir Client ID giriniz.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal initialBalance))
            {
                MessageBox.Show("Geçerli bir başlangıç bakiyesi giriniz.");
                return;
            }

            try
            {
                accountService.OpenAccount(clientId, initialBalance);
                MessageBox.Show("Hesap açıldı.");
                AccountManagerTest_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountID.Text.Trim(), out int accountId))
            {
                MessageBox.Show("Geçerli bir hesap ID girin.");
                return;
            }

            try
            {
                accountService.CloseAccount(accountId);
                MessageBox.Show("Hesap kapatıldı.");
                AccountManagerTest_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountID.Text.Trim(), out int accountId) ||
               !decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("Lütfen geçerli hesap ID ve tutar girin.");
                return;
            }

            try
            {
                accountService.DepositMoney(accountId, amount);
                MessageBox.Show("Para yatırıldı.");
                AccountManagerTest_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAccountID.Text.Trim(), out int accountId) ||
                !decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("Lütfen geçerli hesap ID ve tutar girin.");
                return;
            }

            try
            {
                bool success = accountService.WithdrawMoney(accountId, amount);
                if (success)
                {
                    MessageBox.Show("Para çekildi.");
                    AccountManagerTest_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void AccountManagerTest_Load(object sender, EventArgs e)
        {
            lstAccounts.Items.Clear();
            var accounts = accountService.GetAllAccounts();
            foreach (var acc in accounts)
            {
                lstAccounts.Items.Add(acc);
            }

        }

        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedItem != null)
            {
                try
                {
                    string selected = lstAccounts.SelectedItem.ToString();

                    // Format: ID: 3, Müşteri: 2002, Bakiye: 676,00
                    string[] parts = selected.Split(',');

                    string accountIdPart = parts[0]; // ID: 3
                    string clientIdPart = parts[1];  // Müşteri: 2002
                    string balancePart = parts[2];  // Bakiye: 676,00

                    txtAccountID.Text = accountIdPart.Split(':')[1].Trim();
                    txtClientID.Text = clientIdPart.Split(':')[1].Trim();
                    txtAmount.Text = balancePart.Split(':')[1].Trim();
                }
                catch (Exception)
                {
                    MessageBox.Show("Satırdan bilgi okunamadı.");
                }
            }
        }
    }
}
