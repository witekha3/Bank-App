namespace Bank_App
{
    partial class LogInForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.MottoLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.IncorrectPasswordLabel = new System.Windows.Forms.Label();
            this.IncorrectLoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LeftPanel.Controls.Add(this.MottoLabel);
            this.LeftPanel.Controls.Add(this.LogoPictureBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(400, 550);
            this.LeftPanel.TabIndex = 0;
            // 
            // MottoLabel
            // 
            this.MottoLabel.AutoSize = true;
            this.MottoLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MottoLabel.Location = new System.Drawing.Point(44, 403);
            this.MottoLabel.Name = "MottoLabel";
            this.MottoLabel.Size = new System.Drawing.Size(325, 34);
            this.MottoLabel.TabIndex = 7;
            this.MottoLabel.Text = "Trust. Safety. Reliability.";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(50, 50);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(300, 350);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 6;
            this.LogoPictureBox.TabStop = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.RightPanel.Controls.Add(this.ExitButton);
            this.RightPanel.Controls.Add(this.LogInButton);
            this.RightPanel.Controls.Add(this.IncorrectPasswordLabel);
            this.RightPanel.Controls.Add(this.IncorrectLoginLabel);
            this.RightPanel.Controls.Add(this.PasswordTextBox);
            this.RightPanel.Controls.Add(this.PasswordLabel);
            this.RightPanel.Controls.Add(this.LogInTextBox);
            this.RightPanel.Controls.Add(this.LoginLabel);
            this.RightPanel.Controls.Add(this.TitleLabel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(400, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(400, 550);
            this.RightPanel.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(220, 450);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 40);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInButton.Location = new System.Drawing.Point(75, 450);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(140, 40);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // IncorrectPasswordLabel
            // 
            this.IncorrectPasswordLabel.AutoSize = true;
            this.IncorrectPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPasswordLabel.Location = new System.Drawing.Point(20, 235);
            this.IncorrectPasswordLabel.Name = "IncorrectPasswordLabel";
            this.IncorrectPasswordLabel.Size = new System.Drawing.Size(292, 19);
            this.IncorrectPasswordLabel.TabIndex = 3;
            this.IncorrectPasswordLabel.Text = "Password, which you entered is incorrect.";
            this.IncorrectPasswordLabel.Visible = false;
            // 
            // IncorrectLoginLabel
            // 
            this.IncorrectLoginLabel.AutoSize = true;
            this.IncorrectLoginLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLoginLabel.Location = new System.Drawing.Point(20, 135);
            this.IncorrectLoginLabel.Name = "IncorrectLoginLabel";
            this.IncorrectLoginLabel.Size = new System.Drawing.Size(265, 19);
            this.IncorrectLoginLabel.TabIndex = 3;
            this.IncorrectLoginLabel.Text = "Login, which you entered is incorrect.";
            this.IncorrectLoginLabel.Visible = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.Location = new System.Drawing.Point(25, 205);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(340, 28);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(19, 170);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(108, 23);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogInTextBox.Location = new System.Drawing.Point(25, 105);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(340, 28);
            this.LogInTextBox.TabIndex = 2;
            this.LogInTextBox.Text = "Login";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(20, 70);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(65, 23);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLabel.Location = new System.Drawing.Point(20, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(96, 34);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Log In";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label IncorrectPasswordLabel;
        private System.Windows.Forms.Label IncorrectLoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label MottoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}

