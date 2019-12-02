namespace Bank_App.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ShowClientDetailsButton = new System.Windows.Forms.Button();
            this.RemoveClient = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
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
            this.LeftPanel.Controls.Add(this.LogOutButton);
            this.LeftPanel.Controls.Add(this.ShowClientDetailsButton);
            this.LeftPanel.Controls.Add(this.RemoveClient);
            this.LeftPanel.Controls.Add(this.AddClientButton);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(270, 800);
            this.LeftPanel.TabIndex = 0;
            // 
            // LogOutButton
            // 
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.Location = new System.Drawing.Point(3, 415);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(261, 70);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ShowClientDetailsButton
            // 
            this.ShowClientDetailsButton.FlatAppearance.BorderSize = 0;
            this.ShowClientDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowClientDetailsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowClientDetailsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowClientDetailsButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowClientDetailsButton.Image")));
            this.ShowClientDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowClientDetailsButton.Location = new System.Drawing.Point(3, 339);
            this.ShowClientDetailsButton.Name = "ShowClientDetailsButton";
            this.ShowClientDetailsButton.Size = new System.Drawing.Size(261, 70);
            this.ShowClientDetailsButton.TabIndex = 1;
            this.ShowClientDetailsButton.Text = "Client Details";
            this.ShowClientDetailsButton.UseVisualStyleBackColor = true;
            // 
            // RemoveClient
            // 
            this.RemoveClient.FlatAppearance.BorderSize = 0;
            this.RemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveClient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RemoveClient.Image = ((System.Drawing.Image)(resources.GetObject("RemoveClient.Image")));
            this.RemoveClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveClient.Location = new System.Drawing.Point(3, 262);
            this.RemoveClient.Name = "RemoveClient";
            this.RemoveClient.Size = new System.Drawing.Size(262, 70);
            this.RemoveClient.TabIndex = 1;
            this.RemoveClient.Text = "Remove Client";
            this.RemoveClient.UseVisualStyleBackColor = true;
            // 
            // AddClientButton
            // 
            this.AddClientButton.FlatAppearance.BorderSize = 0;
            this.AddClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddClientButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddClientButton.Image = ((System.Drawing.Image)(resources.GetObject("AddClientButton.Image")));
            this.AddClientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddClientButton.Location = new System.Drawing.Point(3, 186);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(261, 70);
            this.AddClientButton.TabIndex = 1;
            this.AddClientButton.Text = "Add Client";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.MottoLabel);
            this.LogoPanel.Controls.Add(this.LogoPictureBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(270, 180);
            this.LogoPanel.TabIndex = 0;
            // 
            // MottoLabel
            // 
            this.MottoLabel.AutoSize = true;
            this.MottoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MottoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MottoLabel.Location = new System.Drawing.Point(25, 143);
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
            this.CentralPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(270, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(730, 800);
            this.CentralPanel.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.CentralPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminMainForm";
            this.LeftPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label MottoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button RemoveClient;
        private System.Windows.Forms.Button ShowClientDetailsButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}