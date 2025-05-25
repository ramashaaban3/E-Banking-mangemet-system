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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Basit doğrulama (boş alan var mı?)
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblSuccess.ForeColor = Color.Red;
                lblSuccess.Text = "Lütfen tüm alanları doldurun.";
                lblSuccess.Visible = true;

                return;
            }

            // Veritabanına kayıt işlemi
            try
            {
                UserDataAccess.InsertUser(fullName, username, password);

                lblSuccess.ForeColor = Color.Green;
                lblSuccess.Text = "☑ KAYIT BAŞARILI  ";
                lblSuccess.Visible = true;

                // Form temizleme
                txtFullName.Clear();
                txtUsername.Clear();
                txtPassword.Clear();

                // 3 saniye sonra label'ı gizle
                var timer = new Timer();
                timer.Interval = 1000; // 2 saniye
                timer.Tick += (s, args) =>
                {
                    lblSuccess.Visible = false;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
            catch (Exception ex)
            {
                lblSuccess.ForeColor = Color.Red;
                lblSuccess.Text = "Hata oluştu: " + ex.Message;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
