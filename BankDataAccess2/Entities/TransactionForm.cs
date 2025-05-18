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
    public partial class TransactionForm: Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            int accountId = int.Parse(txtAccountID.Text);
            decimal amount = decimal.Parse(txtAmount.Text);
            string type = cmbType.SelectedItem.ToString();

            TransactionsDataAccess.InsertTransaction(accountId, amount, type);
            MessageBox.Show("İşlem başarıyla eklendi.");
        }

        private void btnListTransactions_Click(object sender, EventArgs e)
        {
            int accountId = int.Parse(txtAccountID.Text);
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
