namespace BankDataAccess2.Entities
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnListAccounts = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.BackColor = System.Drawing.Color.Transparent;
            this.lblClientID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClientID.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblClientID.Location = new System.Drawing.Point(218, 111);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(116, 30);
            this.lblClientID.TabIndex = 0;
            this.lblClientID.Text = "Müşteri No";
            this.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(405, 109);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(124, 30);
            this.txtClientID.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBalance.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblBalance.Location = new System.Drawing.Point(218, 200);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(150, 30);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Hesap Bakiyesi";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(405, 198);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(124, 30);
            this.txtBalance.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Location = new System.Drawing.Point(613, 109);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(93, 33);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Ekle";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnListAccounts
            // 
            this.btnListAccounts.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListAccounts.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnListAccounts.ForeColor = System.Drawing.Color.White;
            this.btnListAccounts.Location = new System.Drawing.Point(613, 196);
            this.btnListAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListAccounts.Name = "btnListAccounts";
            this.btnListAccounts.Size = new System.Drawing.Size(93, 33);
            this.btnListAccounts.TabIndex = 5;
            this.btnListAccounts.Text = "Listele";
            this.btnListAccounts.UseVisualStyleBackColor = false;
            this.btnListAccounts.Click += new System.EventHandler(this.btnListAccounts_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.BackColor = System.Drawing.Color.SeaShell;
            this.lstAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 23;
            this.lstAccounts.Location = new System.Drawing.Point(211, 317);
            this.lstAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(495, 117);
            this.lstAccounts.TabIndex = 6;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 60);
            this.pnlTop.TabIndex = 7;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.ForeColor = System.Drawing.Color.White;
            this.pnlBottom.Location = new System.Drawing.Point(0, 607);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1000, 40);
            this.pnlBottom.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Yönetim Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "© 2025 BankPro. Tüm hakları saklıdır.";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.btnListAccounts);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblClientID);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Yönetim Paneli";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnListAccounts;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}