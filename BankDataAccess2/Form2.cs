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

namespace BankDataAccess2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = UserManager.Login(txtFullName.Text, txtUsername.Text, txtPassword.Text);
            MessageBox.Show(success ? "Giriş başarılı!" : "Giriş başarısız!");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserManager.IsUsernameTaken(txtUsername.Text))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                    return;
                }

                if (UserManager.IsFullNameTaken(txtFullName.Text))
                {
                    MessageBox.Show("Bu ad soyad ile zaten kayıtlı bir kullanıcı var!");
                    return;
                }

                UserManager.Register(txtFullName.Text, txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Kayıt başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            var users = UserManager.GetAllUsers();
            foreach (var user in users)
            {
                lstUsers.Items.Add(user);
            }

        }
    }
}
