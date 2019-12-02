namespace Bank_App.UserControls
{
    partial class AddingClientUserControl1
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateClientLabel = new System.Windows.Forms.Label();
            this.IncorrectPasswordLabel1 = new System.Windows.Forms.Label();
            this.IncorrectLoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RePasswordLabel = new System.Windows.Forms.Label();
            this.RePasswordTextBox = new System.Windows.Forms.TextBox();
            this.IncorrectRePasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IncorrectEmailLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.IncorrectPasswordLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateClientLabel
            // 
            this.CreateClientLabel.AutoSize = true;
            this.CreateClientLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateClientLabel.Location = new System.Drawing.Point(20, 20);
            this.CreateClientLabel.Name = "CreateClientLabel";
            this.CreateClientLabel.Size = new System.Drawing.Size(491, 34);
            this.CreateClientLabel.TabIndex = 0;
            this.CreateClientLabel.Text = "Create Client Account (Step 1 of 2)";
            this.CreateClientLabel.UseWaitCursor = true;
            // 
            // IncorrectPasswordLabel1
            // 
            this.IncorrectPasswordLabel1.AutoSize = true;
            this.IncorrectPasswordLabel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPasswordLabel1.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPasswordLabel1.Location = new System.Drawing.Point(20, 235);
            this.IncorrectPasswordLabel1.Name = "IncorrectPasswordLabel1";
            this.IncorrectPasswordLabel1.Size = new System.Drawing.Size(292, 19);
            this.IncorrectPasswordLabel1.TabIndex = 8;
            this.IncorrectPasswordLabel1.Text = "Password, which you entered is incorrect.";
            this.IncorrectPasswordLabel1.UseWaitCursor = true;
            this.IncorrectPasswordLabel1.Visible = false;
            // 
            // IncorrectLoginLabel
            // 
            this.IncorrectLoginLabel.AutoSize = true;
            this.IncorrectLoginLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLoginLabel.Location = new System.Drawing.Point(20, 135);
            this.IncorrectLoginLabel.Name = "IncorrectLoginLabel";
            this.IncorrectLoginLabel.Size = new System.Drawing.Size(265, 19);
            this.IncorrectLoginLabel.TabIndex = 9;
            this.IncorrectLoginLabel.Text = "Login, which you entered is incorrect.";
            this.IncorrectLoginLabel.UseWaitCursor = true;
            this.IncorrectLoginLabel.Visible = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.Location = new System.Drawing.Point(22, 205);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 28);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.UseWaitCursor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(20, 170);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 23);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.UseWaitCursor = true;
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogInTextBox.Location = new System.Drawing.Point(25, 105);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(300, 28);
            this.LogInTextBox.TabIndex = 7;
            this.LogInTextBox.Text = "Login";
            this.LogInTextBox.UseWaitCursor = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(20, 70);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(68, 23);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Login:";
            this.LoginLabel.UseWaitCursor = true;
            // 
            // RePasswordLabel
            // 
            this.RePasswordLabel.AutoSize = true;
            this.RePasswordLabel.Location = new System.Drawing.Point(20, 270);
            this.RePasswordLabel.Name = "RePasswordLabel";
            this.RePasswordLabel.Size = new System.Drawing.Size(106, 23);
            this.RePasswordLabel.TabIndex = 4;
            this.RePasswordLabel.Text = "Password:";
            this.RePasswordLabel.UseWaitCursor = true;
            // 
            // RePasswordTextBox
            // 
            this.RePasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RePasswordTextBox.Location = new System.Drawing.Point(25, 305);
            this.RePasswordTextBox.Name = "RePasswordTextBox";
            this.RePasswordTextBox.Size = new System.Drawing.Size(300, 28);
            this.RePasswordTextBox.TabIndex = 6;
            this.RePasswordTextBox.Text = "Password";
            this.RePasswordTextBox.UseSystemPasswordChar = true;
            this.RePasswordTextBox.UseWaitCursor = true;
            // 
            // IncorrectRePasswordLabel
            // 
            this.IncorrectRePasswordLabel.AutoSize = true;
            this.IncorrectRePasswordLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectRePasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectRePasswordLabel.Location = new System.Drawing.Point(20, 335);
            this.IncorrectRePasswordLabel.Name = "IncorrectRePasswordLabel";
            this.IncorrectRePasswordLabel.Size = new System.Drawing.Size(308, 19);
            this.IncorrectRePasswordLabel.TabIndex = 8;
            this.IncorrectRePasswordLabel.Text = "Passwords, which you entered are different.";
            this.IncorrectRePasswordLabel.UseWaitCursor = true;
            this.IncorrectRePasswordLabel.Visible = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(20, 370);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(74, 23);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email: ";
            this.EmailLabel.UseWaitCursor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailTextBox.Location = new System.Drawing.Point(25, 405);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(300, 28);
            this.EmailTextBox.TabIndex = 7;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.UseWaitCursor = true;
            // 
            // IncorrectEmailLabel
            // 
            this.IncorrectEmailLabel.AutoSize = true;
            this.IncorrectEmailLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectEmailLabel.Location = new System.Drawing.Point(20, 435);
            this.IncorrectEmailLabel.Name = "IncorrectEmailLabel";
            this.IncorrectEmailLabel.Size = new System.Drawing.Size(266, 19);
            this.IncorrectEmailLabel.TabIndex = 9;
            this.IncorrectEmailLabel.Text = "Email, which you entered is incorrect.";
            this.IncorrectEmailLabel.UseWaitCursor = true;
            this.IncorrectEmailLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(495, 700);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 40);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.UseWaitCursor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextButton.Location = new System.Drawing.Point(350, 700);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(140, 40);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.UseWaitCursor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // IncorrectPasswordLabel2
            // 
            this.IncorrectPasswordLabel2.AutoSize = true;
            this.IncorrectPasswordLabel2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPasswordLabel2.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPasswordLabel2.Location = new System.Drawing.Point(20, 335);
            this.IncorrectPasswordLabel2.Name = "IncorrectPasswordLabel2";
            this.IncorrectPasswordLabel2.Size = new System.Drawing.Size(292, 19);
            this.IncorrectPasswordLabel2.TabIndex = 8;
            this.IncorrectPasswordLabel2.Text = "Password, which you entered is incorrect.";
            this.IncorrectPasswordLabel2.UseWaitCursor = true;
            this.IncorrectPasswordLabel2.Visible = false;
            // 
            // AddingClientUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.IncorrectRePasswordLabel);
            this.Controls.Add(this.IncorrectPasswordLabel2);
            this.Controls.Add(this.IncorrectPasswordLabel1);
            this.Controls.Add(this.IncorrectEmailLabel);
            this.Controls.Add(this.IncorrectLoginLabel);
            this.Controls.Add(this.RePasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RePasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LogInTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.CreateClientLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddingClientUserControl1";
            this.Size = new System.Drawing.Size(730, 800);
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateClientLabel;
        private System.Windows.Forms.Label IncorrectPasswordLabel1;
        private System.Windows.Forms.Label IncorrectLoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label RePasswordLabel;
        private System.Windows.Forms.TextBox RePasswordTextBox;
        private System.Windows.Forms.Label IncorrectRePasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label IncorrectEmailLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label IncorrectPasswordLabel2;
    }
}
