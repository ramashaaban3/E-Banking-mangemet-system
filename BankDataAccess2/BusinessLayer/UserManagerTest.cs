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
    public partial class UserManagerTest : Form
    {
        public UserManagerTest()
        {
            InitializeComponent();
            this.Text = "UserManager Test Arayüzü";
        }

        private IUserService userService = new UserManager();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = userService.Login(txtFullName.Text, txtUsername.Text, txtPassword.Text);
            MessageBox.Show(success ? "Giriş başarılı!" : "Giriş başarısız!");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (userService.IsUsernameTaken(txtUsername.Text))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                    return;
                }

                if (userService.IsFullNameTaken(txtFullName.Text))
                {
                    MessageBox.Show("Bu ad soyad ile zaten kayıtlı bir kullanıcı var!");
                    return;
                }

                if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Şifre en az 6 karakter olmalıdır.");
                    return;
                }

                userService.Register(txtFullName.Text, txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Kayıt başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void UserManagerTest_Load(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            var users = userService.GetAllUsers();
            foreach (var user in users)
            {
                lstUsers.Items.Add(user);
            }

        }
    }
}
