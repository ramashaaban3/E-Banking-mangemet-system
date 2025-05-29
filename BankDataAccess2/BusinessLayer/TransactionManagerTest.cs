using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDataAccess2.BusinessLayer
{
    public partial class TransactionManagerTest : Form
    {
        private ITransactionService transactionService = new TransactionManager();
        public TransactionManagerTest()
        {
            InitializeComponent();
            this.Text = "TransactionManager Test Arayüzü";
        }

        private void TransactionManagerTest_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHesapID.Text))
                return;
            if (!int.TryParse(txtHesapID.Text, out int accountId))
            {
                MessageBox.Show("Hesap ID geçersiz.");
                return;
            }

            lstTransactions.Items.Clear();
            var transactions = transactionService.GetTransactionHistory(accountId);
            foreach (var t in transactions)
            {
                lstTransactions.Items.Add(t);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFromAccount.Text, out int fromId) ||
                !int.TryParse(txtToAccount.Text, out int toId) ||
                !decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Lütfen geçerli değerler girin.");
                return;
            }

            // Açıklama üret
            string desc = $"Hesap {fromId} → {toId} {amount} ₺ transfer edildi";

            bool success = transactionService.TransferMoney(fromId, toId, amount, desc);
            if (success)
            {
                MessageBox.Show("Transfer başarılı!");
                txtHesapID.Text = txtFromAccount.Text; // otomatik seçim
                LoadTransactions(); // sadece burda çağrılır
            }
            else
            {
                MessageBox.Show("Transfer başarısız!");
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            if (!int.TryParse(txtHesapID.Text, out int accountId))
            {
                MessageBox.Show("Hesap ID geçersiz.");
                return;
            }

            lstTransactions.Items.Clear();
            var transactions = transactionService.GetTransactionHistory(accountId);
            foreach (var t in transactions)
            {
                lstTransactions.Items.Add(t);
            }
        }

        private void lstTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
