using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
// using Entities;
using BankDataAccess2.DataAccess;
using BankDataAccess2.Entities;

namespace BankDataAccess2.Entities
{
    public partial class ClientForm: Form
    {
        // Client işlemlerini gerçekleştirmek için ClientManager kullanılıyor
        private ClientManager clientManager = new ClientManager();
        public ClientForm()
        {
            InitializeComponent();
        }

        // Ekle butonunun üstüne gelindiğinde arka plan rengini değiştirir
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.RoyalBlue;
        }

        // Fare butonun üstünden ayrıldığında eski rengini geri verir
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = ColorTranslator.FromHtml("#007ACC");
        }

        // Müşteri ekleme işlemi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtClientName.Text;
            string phone = txtPhone.Text;

            clientManager.AddClient(name, phone);        // Yeni müşteri ekleniyor
            MessageBox.Show("Müşteri başarıyla eklendi.");
            RefreshClientList();                         // Liste güncelleniyor
        }

        // Müşteri güncelleme işlemi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string originalName = txtClientName.Text;        // Güncellenmeden önceki isim
            string newName = txtClientName.Text;            // Yeni isim
            string newPhone = txtPhone.Text;                // Yeni telefon numarası

            clientManager.UpdateClient(originalName, newName, newPhone);        // Güncelleme işlemi
            MessageBox.Show("Müşteri güncellendi.");
            RefreshClientList();                    // Liste yenileniyor
        }

        // Müşteri silme işlemi
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fullName = txtClientName.Text.Trim();      // Silinecek müşteri ismi

            clientManager.DeleteClient(fullName);            // Silme işlemi
            MessageBox.Show("Müşteri silindi.");
            RefreshClientList();                            // Liste yenileniyor
        }

        // Müşteri arama işlemi
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fullName = txtClientName.Text.Trim();          // Aranacak müşteri ismi

            var client = clientManager.GetClientByName(fullName);    // Veritabanından getir

            if (client != null && !string.IsNullOrWhiteSpace(client.FullName))
            {
                txtClientID.Text = client.ClientID.ToString();        // Müşteri ID'si görüntüleniyor
                txtPhone.Text = client.Phone;                        // Telefon bilgisi gösteriliyor
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.");
            }
        }

        // Form yüklendiğinde müşteri listesi otomatik olarak yenilenir
        private void ClientForm_Load(object sender, EventArgs e)
        {
            RefreshClientList();
        }

        // Müşteri listesini ListBox'ta günceller
        private void RefreshClientList()
        {
            lstClients.Items.Clear();            // Liste temizleniyor
            var clients = clientManager.GetAllClients();    // Tüm müşteriler alınıyor

            foreach (var c in clients)
            {
                lstClients.Items.Add(c);                    // Her müşteri listeye ekleniyor
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
