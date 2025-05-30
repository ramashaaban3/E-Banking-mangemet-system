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
            InitializeComponent();    // Form bileşenleri başlatılır
        }

        // Giriş butonuna tıklanınca çalışacak olan event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre textBox'lardan alınır
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Kullanıcı veritabanından sorgulanır
            var user = UserDataAccess.GetUserByUsername(username);

            // Kullanıcı bulunduysa ve şifre doğruysa
            if (user.Username != null && user.Password == password)
            {
                MessageBox.Show("Giriş başarılı!");        // Başarılı giriş mesajı
                this.Hide();                               // Mevcut giriş formunu gizle
                new ClientForm().Show();                   // ClientForm (Müşteri Formu) açılır
            }
            else
            {
                // Kullanıcı adı veya şifre yanlışsa hata mesajı gösterilir
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
