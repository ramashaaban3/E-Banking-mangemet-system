using System;
using System.Windows.Forms;
using BusinessLayer;

namespace BankDataAccess2
{
    public partial class ClientManagerTest : Form
    {
        public ClientManagerTest()
        {
            InitializeComponent();
            this.Text = "ClientManager Test Arayüzü";
        }

        private IClientService clientService = new ClientManager();

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClients.SelectedItem != null)
            {
                string selectedLine = lstClients.SelectedItem.ToString();
                string[] parts = selectedLine.Split('-');

                if (parts.Length >= 2)
                {
                    txtClientName.Text = parts[0].Trim();
                    txtPhone.Text = parts[1].Trim();
                }
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                clientService.AddClient(txtClientName.Text, txtPhone.Text);
                MessageBox.Show("Müşteri eklendi.");
                ClientManagerTest_Load_1(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (lstClients.SelectedItem == null)
            {
                MessageBox.Show("Lütfen müşteri seçin.");
                return;
            }

            string originalName = lstClients.SelectedItem.ToString();
            try
            {
                clientService.UpdateClient(originalName, txtClientName.Text, txtPhone.Text);
                MessageBox.Show("Müşteri güncellendi.");
                ClientManagerTest_Load_1(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (lstClients.SelectedItem == null)
            {
                MessageBox.Show("Lütfen müşteri seçin.");
                return;
            }

            string selectedName = lstClients.SelectedItem.ToString();
            try
            {
                clientService.DeleteClient(selectedName);
                MessageBox.Show("Müşteri silindi.");
                ClientManagerTest_Load_1(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void ClientManagerTest_Load_1(object sender, EventArgs e)
        {
            lstClients.Items.Clear();
            var clients = clientService.GetAllClients(); // List<string>
            foreach (var c in clients)
            {
                lstClients.Items.Add(c); // çünkü zaten string
            }

        }
    }
}
