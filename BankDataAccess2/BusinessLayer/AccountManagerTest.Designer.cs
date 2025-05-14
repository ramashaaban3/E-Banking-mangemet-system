namespace BankDataAccess2.BusinessLayer
{
    partial class AccountManagerTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnYatir = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(127, 56);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(179, 22);
            this.txtClientID.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(127, 176);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(179, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(127, 90);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(179, 22);
            this.txtAccountID.TabIndex = 3;
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Location = new System.Drawing.Point(27, 221);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(106, 41);
            this.btnHesapAc.TabIndex = 4;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(27, 286);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(106, 41);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Hesabı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(158, 286);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(106, 41);
            this.btnCek.TabIndex = 6;
            this.btnCek.Text = "Para Çek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnYatir
            // 
            this.btnYatir.Location = new System.Drawing.Point(158, 221);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(106, 41);
            this.btnYatir.TabIndex = 7;
            this.btnYatir.Text = "Para Yatır";
            this.btnYatir.UseVisualStyleBackColor = true;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 16;
            this.lstAccounts.Location = new System.Drawing.Point(395, 56);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(293, 180);
            this.lstAccounts.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Müşteri ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hesap ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hesap açarken Hesap ID banka tarafından belirlenir";
            // 
            // AccountManagerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtClientID);
            this.Name = "AccountManagerTest";
            this.Text = "AccountManagerTest";
            this.Load += new System.EventHandler(this.AccountManagerTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}