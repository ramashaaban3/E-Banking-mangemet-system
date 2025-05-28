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
using System.Drawing.Drawing2D;


namespace BankDataAccess2.Entities
{
    public partial class LoginForm: Form
    {
        // Formun kurucu metodu (initialize işlemleri yapılır)
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var user = UserDataAccess.GetUserByUsername(username);

            if (user.Username != null && user.Password == password)
            {
                MessageBox.Show("Giriş başarılı!");
                // Örn: yeni formu aç
                this.Hide();
                new ClientForm().Show(); // veya ana menü
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //// Panel boyutlarını al
            //Rectangle rect = panel1.ClientRectangle;

            //// Renkleri ve yönü tanımla (soldan sağa geçişli)
            //using (LinearGradientBrush brush = new LinearGradientBrush(
            //    rect,
            //    Color.Orange,
            //    Color.Goldenrod,
            //    LinearGradientMode.Horizontal)) // Dikey istersen Vertical yaz
            //{
            //    e.Graphics.FillRectangle(brush, rect);
            //}


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
