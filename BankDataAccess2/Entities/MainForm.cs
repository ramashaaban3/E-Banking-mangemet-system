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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TransactionForm().Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClientForm().Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountForm().Show();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show(); // admin paneli
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
