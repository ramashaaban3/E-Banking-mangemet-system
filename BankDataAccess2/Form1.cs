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

namespace BankDataAccess2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            {
                InitializeComponent(); // Bu satır %100 gerekli
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                var users = UserDataAccess.GetAllUsers();
                lstKullanicilar.Items.Clear();

                foreach (var user in users)
                {
                    lstKullanicilar.Items.Add(user);
                }
        }



    private void btnKullaniciEkle_Click(object sender, EventArgs e)
            {
            //Yeni kullanıcı ekledikten sonra listeyi yenile
            try
            {
                    UserDataAccess.InsertUser("Yeni Kullanıcı5", "yeniuser5", "1234");
                    MessageBox.Show("Kullanıcı eklendi.");

                    // Listeyi güncelle
                    var users = UserDataAccess.GetAllUsers();
                    lstKullanicilar.Items.Clear();
                    foreach (var user in users)
                    {
                        lstKullanicilar.Items.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: " + ex.Message);
                }
            

            try
            {
                    // Test amaçlı sabit değerlerle kullanıcı ekle
                    UserDataAccess.InsertUser("Rama_Shaaban6", "rama_shaaban6", "1234");
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: " + ex.Message);
                }
            }


        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem != null)
            {
                string selectedFullName = lstKullanicilar.SelectedItem.ToString();

                try
                {
                    var userDetails = UserDataAccess.GetUserByFullName(selectedFullName);

                    txtFullName.Text = userDetails.FullName;
                    txtUsername.Text = userDetails.Username;
                    txtPassword.Text = userDetails.Password;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detay gösterme hatası: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
       { }

        private void btnGunelle_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce bir kullanıcı seçin.");
                return;
            }

            // Seçilen kullanıcı (güncellenecek kişi)
            string originalFullName = lstKullanicilar.SelectedItem.ToString();

            // TextBox’lardaki yeni bilgiler
            string newFullName = txtFullName.Text.Trim();
            string newUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newFullName) || string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Ad ve kullanıcı adı boş olamaz.");
                return;
            }

            try
            {
                UserDataAccess.UpdateUserByFullName(originalFullName, newFullName, newUsername, newPassword);
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");

                // Listeyi güncelle
                var users = UserDataAccess.GetAllUsers();
                lstKullanicilar.Items.Clear();
                foreach (var user in users)
                {
                    lstKullanicilar.Items.Add(user);
                }

                // Güncellenen kullanıcıyı yeniden seç
                lstKullanicilar.SelectedItem = newFullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçin.");
                return;
            }

            string fullNameToDelete = lstKullanicilar.SelectedItem.ToString();

            DialogResult sonuc = MessageBox.Show($"{fullNameToDelete} adlı kullanıcı silinsin mi?",
                                                  "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    UserDataAccess.DeleteUserByFullName(fullNameToDelete);
                    MessageBox.Show("Kullanıcı silindi.");

                    // Listeyi yenile
                    var users = UserDataAccess.GetAllUsers();
                    lstKullanicilar.Items.Clear();
                    foreach (var user in users)
                    {
                        lstKullanicilar.Items.Add(user);
                    }

                    // TextBox’ları temizle
                    txtFullName.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }
    }
}
