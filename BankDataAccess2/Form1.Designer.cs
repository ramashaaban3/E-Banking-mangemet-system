using System.Drawing;
using System.Windows.Forms;

namespace BankDataAccess2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodu
        /// kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.lstKullanicilar = new System.Windows.Forms.ListBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGunelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(685, 12);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(150, 50);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // lstKullanicilar
            // 
            this.lstKullanicilar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstKullanicilar.FormattingEnabled = true;
            this.lstKullanicilar.ItemHeight = 16;
            this.lstKullanicilar.Location = new System.Drawing.Point(12, 20);
            this.lstKullanicilar.Name = "lstKullanicilar";
            this.lstKullanicilar.Size = new System.Drawing.Size(462, 180);
            this.lstKullanicilar.TabIndex = 1;
            this.lstKullanicilar.SelectedIndexChanged += new System.EventHandler(this.lstKullanicilar_SelectedIndexChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtFullName.Location = new System.Drawing.Point(12, 233);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Text = "\r\n";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUsername.Location = new System.Drawing.Point(12, 280);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPassword.Location = new System.Drawing.Point(12, 332);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnGunelle
            // 
            this.btnGunelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGunelle.Location = new System.Drawing.Point(685, 78);
            this.btnGunelle.Name = "btnGunelle";
            this.btnGunelle.Size = new System.Drawing.Size(150, 50);
            this.btnGunelle.TabIndex = 5;
            this.btnGunelle.Text = "Güncelle\r\n";
            this.btnGunelle.UseVisualStyleBackColor = false;
            this.btnGunelle.Click += new System.EventHandler(this.btnGunelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnSil.Location = new System.Drawing.Point(685, 152);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 50);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnKullaniciEkle;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1071, 462);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGunelle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lstKullanicilar);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button button1;
        private ListBox lstKullanicilar;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnGunelle;
        private Button btnSil;
    }
}