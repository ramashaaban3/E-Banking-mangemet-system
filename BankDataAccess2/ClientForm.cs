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

namespace BankDataAccess2
{
    public partial class ClientForm: Form
    {
        private ClientManager clientManager = new ClientManager();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.RoyalBlue;
        }
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = ColorTranslator.FromHtml("#007ACC");
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtClientName.Text;
            string phone = txtPhone.Text;

            clientManager.AddClient(name, phone);
            MessageBox.Show("Müşteri başarıyla eklendi.");
            RefreshClientList();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string originalName = txtClientName.Text; // Gerçek isim buradan alınmalı
            string newName = txtClientName.Text;
            string newPhone = txtPhone.Text;

            clientManager.UpdateClient(originalName, newName, newPhone);
            MessageBox.Show("Müşteri güncellendi.");
            RefreshClientList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fullName = txtClientName.Text.Trim();  // ID değil, isim!

            clientManager.DeleteClient(fullName);
            MessageBox.Show("Müşteri silindi.");
            RefreshClientList();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fullName = txtClientName.Text.Trim(); // artık ID yerine gerçek adı kullanıyoruz

            var client = clientManager.GetClientByName(fullName);

            if (client != null && !string.IsNullOrWhiteSpace(client.FullName))
            {
                txtClientID.Text = client.ClientID.ToString(); // ID’yi de geri yaz
                txtPhone.Text = client.Phone;
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.");
            }
        }


        private void ClientForm_Load(object sender, EventArgs e)
        {
            RefreshClientList();
        }

        private void RefreshClientList()
        {
            lstClients.Items.Clear();
            var clients = clientManager.GetAllClients();

            foreach (var c in clients)
            {
                lstClients.Items.Add(c);
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
