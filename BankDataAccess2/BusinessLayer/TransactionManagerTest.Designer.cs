namespace BankDataAccess2.BusinessLayer
{
    partial class TransactionManagerTest
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
            this.txtFromAccount = new System.Windows.Forms.TextBox();
            this.txtHesapID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtToAccount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFromAccount
            // 
            this.txtFromAccount.Location = new System.Drawing.Point(163, 45);
            this.txtFromAccount.Name = "txtFromAccount";
            this.txtFromAccount.Size = new System.Drawing.Size(196, 22);
            this.txtFromAccount.TabIndex = 0;
            // 
            // txtHesapID
            // 
            this.txtHesapID.Location = new System.Drawing.Point(163, 171);
            this.txtHesapID.Name = "txtHesapID";
            this.txtHesapID.Size = new System.Drawing.Size(196, 22);
            this.txtHesapID.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(163, 126);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(196, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // txtToAccount
            // 
            this.txtToAccount.Location = new System.Drawing.Point(163, 84);
            this.txtToAccount.Name = "txtToAccount";
            this.txtToAccount.Size = new System.Drawing.Size(196, 22);
            this.txtToAccount.TabIndex = 3;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(281, 284);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(155, 37);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer işlemi";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(88, 284);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(153, 37);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Hesap Geçmişi";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gönderen hesap ID";
            // 
            // lstTransactions
            // 
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.ItemHeight = 16;
            this.lstTransactions.Location = new System.Drawing.Point(473, 45);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(272, 276);
            this.lstTransactions.TabIndex = 7;
            this.lstTransactions.SelectedIndexChanged += new System.EventHandler(this.lstTransactions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hesap ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transfer tutarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alıcı hesap ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sadece geçmişi sorgulayacağınız hesap için giriniz";
            // 
            // TransactionManagerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTransactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtToAccount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtHesapID);
            this.Controls.Add(this.txtFromAccount);
            this.Name = "TransactionManagerTest";
            this.Text = "TransactionManagerTest";
            this.Load += new System.EventHandler(this.TransactionManagerTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromAccount;
        private System.Windows.Forms.TextBox txtHesapID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtToAccount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}