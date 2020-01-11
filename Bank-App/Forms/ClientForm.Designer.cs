namespace Bank_App.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.AccountDetailsButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.InvestmentsButton = new System.Windows.Forms.Button();
            this.TransfersHistoryButton = new System.Windows.Forms.Button();
            this.TransfersButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.MottoLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LeftPanel.Controls.Add(this.AccountDetailsButton);
            this.LeftPanel.Controls.Add(this.LogOutButton);
            this.LeftPanel.Controls.Add(this.InvestmentsButton);
            this.LeftPanel.Controls.Add(this.TransfersHistoryButton);
            this.LeftPanel.Controls.Add(this.TransfersButton);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(270, 800);
            this.LeftPanel.TabIndex = 1;
            // 
            // AccountDetailsButton
            // 
            this.AccountDetailsButton.FlatAppearance.BorderSize = 0;
            this.AccountDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountDetailsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AccountDetailsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AccountDetailsButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountDetailsButton.Image")));
            this.AccountDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountDetailsButton.Location = new System.Drawing.Point(3, 488);
            this.AccountDetailsButton.Name = "AccountDetailsButton";
            this.AccountDetailsButton.Size = new System.Drawing.Size(261, 70);
            this.AccountDetailsButton.TabIndex = 1;
            this.AccountDetailsButton.Text = "Account Details";
            this.AccountDetailsButton.UseVisualStyleBackColor = true;
            this.AccountDetailsButton.Click += new System.EventHandler(this.AccountDetailsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.Location = new System.Drawing.Point(3, 564);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(261, 70);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // InvestmentsButton
            // 
            this.InvestmentsButton.FlatAppearance.BorderSize = 0;
            this.InvestmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvestmentsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvestmentsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InvestmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("InvestmentsButton.Image")));
            this.InvestmentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InvestmentsButton.Location = new System.Drawing.Point(3, 412);
            this.InvestmentsButton.Name = "InvestmentsButton";
            this.InvestmentsButton.Size = new System.Drawing.Size(261, 70);
            this.InvestmentsButton.TabIndex = 1;
            this.InvestmentsButton.Text = "Investments";
            this.InvestmentsButton.UseVisualStyleBackColor = true;
            this.InvestmentsButton.Click += new System.EventHandler(this.InvestmentsButton_Click);
            // 
            // TransfersHistoryButton
            // 
            this.TransfersHistoryButton.FlatAppearance.BorderSize = 0;
            this.TransfersHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransfersHistoryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransfersHistoryButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TransfersHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("TransfersHistoryButton.Image")));
            this.TransfersHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransfersHistoryButton.Location = new System.Drawing.Point(2, 336);
            this.TransfersHistoryButton.Name = "TransfersHistoryButton";
            this.TransfersHistoryButton.Size = new System.Drawing.Size(262, 70);
            this.TransfersHistoryButton.TabIndex = 1;
            this.TransfersHistoryButton.Text = "History of Transfers";
            this.TransfersHistoryButton.UseVisualStyleBackColor = true;
            this.TransfersHistoryButton.Click += new System.EventHandler(this.DefinedTransfersButton_Click);
            // 
            // TransfersButton
            // 
            this.TransfersButton.FlatAppearance.BorderSize = 0;
            this.TransfersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransfersButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransfersButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TransfersButton.Image = ((System.Drawing.Image)(resources.GetObject("TransfersButton.Image")));
            this.TransfersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransfersButton.Location = new System.Drawing.Point(3, 260);
            this.TransfersButton.Name = "TransfersButton";
            this.TransfersButton.Size = new System.Drawing.Size(261, 70);
            this.TransfersButton.TabIndex = 1;
            this.TransfersButton.Text = "Transfers";
            this.TransfersButton.UseVisualStyleBackColor = true;
            this.TransfersButton.Click += new System.EventHandler(this.TransfersButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.BalanceLabel);
            this.LogoPanel.Controls.Add(this.AccountNumberLabel);
            this.LogoPanel.Controls.Add(this.MottoLabel);
            this.LogoPanel.Controls.Add(this.LogoPictureBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(270, 250);
            this.LogoPanel.TabIndex = 0;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BalanceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BalanceLabel.Location = new System.Drawing.Point(6, 202);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(261, 19);
            this.BalanceLabel.TabIndex = 1;
            this.BalanceLabel.Text = "Balance: 0.00";
            this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AccountNumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccountNumberLabel.Location = new System.Drawing.Point(3, 175);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(264, 18);
            this.AccountNumberLabel.TabIndex = 1;
            this.AccountNumberLabel.Text = "11 1111 1111 1111 1111 1111 1111";
            this.AccountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MottoLabel
            // 
            this.MottoLabel.AutoSize = true;
            this.MottoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MottoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MottoLabel.Location = new System.Drawing.Point(22, 145);
            this.MottoLabel.Name = "MottoLabel";
            this.MottoLabel.Size = new System.Drawing.Size(230, 23);
            this.MottoLabel.TabIndex = 1;
            this.MottoLabel.Text = "Trust. Safety. Relability.";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(270, 131);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // CentralPanel
            // 
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CentralPanel.Location = new System.Drawing.Point(270, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(730, 800);
            this.CentralPanel.TabIndex = 2;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.CentralPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button InvestmentsButton;
        private System.Windows.Forms.Button TransfersHistoryButton;
        private System.Windows.Forms.Button TransfersButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label MottoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Button AccountDetailsButton;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label AccountNumberLabel;
    }
}