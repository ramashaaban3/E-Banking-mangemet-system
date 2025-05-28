using BankDataAccess2.DataAccess;
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

namespace BankDataAccess2.Entities
{
    public partial class TransactionForm: Form
    {
        // Form başlatıldığında InitializeComponent çağrılır.
        public TransactionForm()
        {
            InitializeComponent();
            // btnAddTransaction.Click += btnAddTransaction_Click;
        }

        // Para transferi işlemini gerçekleştiren butonun tıklanma olayı
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            // Gönderen ve alıcı hesap ID'lerini ve tutarı doğrula
            if (!int.TryParse(txtSenderAccount.Text.Trim(), out int senderId) ||
                !int.TryParse(txtReceiverAccount.Text.Trim(), out int receiverId) ||
                !decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("Lütfen geçerli hesap numaraları ve tutar girin.");
                return;
            }

            // Açıklamayı al; boşsa varsayılan bir ifade ekle
            string description = txtDescription.Text.Trim();
            if (string.IsNullOrWhiteSpace(description))
                description = "Açıklama yok";


            try
            {
                TransactionManager manager = new TransactionManager();
                bool success = manager.TransferMoney(senderId, receiverId, amount, description);

                if (success)
                    MessageBox.Show("Transfer başarılı!");
                else
                    MessageBox.Show("Transfer başarısız. Lütfen bilgileri kontrol edin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        // Belirli bir hesabın işlem geçmişini listeleyen buton olayı
        private void btnListTransactions_Click(object sender, EventArgs e)
        {
            // Hesap numarasının geçerli olup olmadığını kontrol et
            if (!int.TryParse(txtSenderAccount.Text.Trim(), out int accountId))
            {
                MessageBox.Show("Geçerli bir hesap numarası girin.");
                return;
            }
            // İşlem listesini temizle ve ilgili hesap için verileri çek
            lstTransactions.Items.Clear();
            var transactions = TransactionsDataAccess.GetTransactionsByAccountID(accountId);
            foreach (var t in transactions)
            {
                lstTransactions.Items.Add(t);
            }
        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
