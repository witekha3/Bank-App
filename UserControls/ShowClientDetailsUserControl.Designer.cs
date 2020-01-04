namespace Bank_App.UserControls
{
    partial class ShowClientDetailsUserControl
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
            this.ClientDetailsLabel = new System.Windows.Forms.Label();
            this.IncorrectPeselLabel = new System.Windows.Forms.Label();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            this.PeselLabel = new System.Windows.Forms.Label();
            this.IncorrectZipCodeLabel = new System.Windows.Forms.Label();
            this.IncorrectPhoneNumberLabel = new System.Windows.Forms.Label();
            this.IncorrectCityNameLabel = new System.Windows.Forms.Label();
            this.IncorrectSurnameLabel = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.ZipCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.CityNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ModifyLabel = new System.Windows.Forms.Label();
            this.IncorrectLoginLabel = new System.Windows.Forms.Label();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.IncorrectEmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientDetailsLabel
            // 
            this.ClientDetailsLabel.AutoSize = true;
            this.ClientDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientDetailsLabel.Location = new System.Drawing.Point(20, 20);
            this.ClientDetailsLabel.Name = "ClientDetailsLabel";
            this.ClientDetailsLabel.Size = new System.Drawing.Size(230, 34);
            this.ClientDetailsLabel.TabIndex = 3;
            this.ClientDetailsLabel.Text = "Account Details";
            this.ClientDetailsLabel.UseWaitCursor = true;
            // 
            // IncorrectPeselLabel
            // 
            this.IncorrectPeselLabel.AutoSize = true;
            this.IncorrectPeselLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPeselLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPeselLabel.Location = new System.Drawing.Point(20, 135);
            this.IncorrectPeselLabel.Name = "IncorrectPeselLabel";
            this.IncorrectPeselLabel.Size = new System.Drawing.Size(321, 19);
            this.IncorrectPeselLabel.TabIndex = 13;
            this.IncorrectPeselLabel.Text = "Pesel number, which you entered is incorrect.";
            this.IncorrectPeselLabel.UseWaitCursor = true;
            this.IncorrectPeselLabel.Visible = false;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PeselTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PeselTextBox.Location = new System.Drawing.Point(25, 105);
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(300, 28);
            this.PeselTextBox.TabIndex = 12;
            this.PeselTextBox.Text = "00000000000";
            this.PeselTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeselTextBox_KeyPress);
            // 
            // PeselLabel
            // 
            this.PeselLabel.AutoSize = true;
            this.PeselLabel.Location = new System.Drawing.Point(20, 70);
            this.PeselLabel.Name = "PeselLabel";
            this.PeselLabel.Size = new System.Drawing.Size(66, 23);
            this.PeselLabel.TabIndex = 11;
            this.PeselLabel.Text = "Pesel:";
            this.PeselLabel.UseWaitCursor = true;
            // 
            // IncorrectZipCodeLabel
            // 
            this.IncorrectZipCodeLabel.AutoSize = true;
            this.IncorrectZipCodeLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectZipCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectZipCodeLabel.Location = new System.Drawing.Point(376, 375);
            this.IncorrectZipCodeLabel.Name = "IncorrectZipCodeLabel";
            this.IncorrectZipCodeLabel.Size = new System.Drawing.Size(292, 19);
            this.IncorrectZipCodeLabel.TabIndex = 32;
            this.IncorrectZipCodeLabel.Text = "Zip Code, which you entered is incorrect.";
            this.IncorrectZipCodeLabel.UseWaitCursor = true;
            this.IncorrectZipCodeLabel.Visible = false;
            // 
            // IncorrectPhoneNumberLabel
            // 
            this.IncorrectPhoneNumberLabel.AutoSize = true;
            this.IncorrectPhoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPhoneNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPhoneNumberLabel.Location = new System.Drawing.Point(372, 475);
            this.IncorrectPhoneNumberLabel.Name = "IncorrectPhoneNumberLabel";
            this.IncorrectPhoneNumberLabel.Size = new System.Drawing.Size(331, 19);
            this.IncorrectPhoneNumberLabel.TabIndex = 31;
            this.IncorrectPhoneNumberLabel.Text = "Phone number, which you entered is incorrect.";
            this.IncorrectPhoneNumberLabel.UseWaitCursor = true;
            this.IncorrectPhoneNumberLabel.Visible = false;
            // 
            // IncorrectCityNameLabel
            // 
            this.IncorrectCityNameLabel.AutoSize = true;
            this.IncorrectCityNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectCityNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectCityNameLabel.Location = new System.Drawing.Point(20, 375);
            this.IncorrectCityNameLabel.Name = "IncorrectCityNameLabel";
            this.IncorrectCityNameLabel.Size = new System.Drawing.Size(301, 19);
            this.IncorrectCityNameLabel.TabIndex = 29;
            this.IncorrectCityNameLabel.Text = "City name, which you entered is incorrect.";
            this.IncorrectCityNameLabel.UseWaitCursor = true;
            this.IncorrectCityNameLabel.Visible = false;
            // 
            // IncorrectSurnameLabel
            // 
            this.IncorrectSurnameLabel.AutoSize = true;
            this.IncorrectSurnameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectSurnameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectSurnameLabel.Location = new System.Drawing.Point(376, 275);
            this.IncorrectSurnameLabel.Name = "IncorrectSurnameLabel";
            this.IncorrectSurnameLabel.Size = new System.Drawing.Size(290, 19);
            this.IncorrectSurnameLabel.TabIndex = 28;
            this.IncorrectSurnameLabel.Text = "Surname, which you entered is incorrect.";
            this.IncorrectSurnameLabel.UseWaitCursor = true;
            this.IncorrectSurnameLabel.Visible = false;
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(20, 275);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(271, 19);
            this.IncorrectNameLabel.TabIndex = 27;
            this.IncorrectNameLabel.Text = "Name, which you entered is incorrect.";
            this.IncorrectNameLabel.UseWaitCursor = true;
            this.IncorrectNameLabel.Visible = false;
            // 
            // ZipCodeTextBox1
            // 
            this.ZipCodeTextBox1.Enabled = false;
            this.ZipCodeTextBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZipCodeTextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ZipCodeTextBox1.Location = new System.Drawing.Point(380, 345);
            this.ZipCodeTextBox1.Name = "ZipCodeTextBox1";
            this.ZipCodeTextBox1.Size = new System.Drawing.Size(110, 28);
            this.ZipCodeTextBox1.TabIndex = 25;
            this.ZipCodeTextBox1.Text = "00-000";
            this.ZipCodeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZipCodeTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTextBox1_KeyPress);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Enabled = false;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(381, 445);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(300, 28);
            this.PhoneNumberTextBox.TabIndex = 26;
            this.PhoneNumberTextBox.Text = "000000000";
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // CityNameTextBox
            // 
            this.CityNameTextBox.Enabled = false;
            this.CityNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CityNameTextBox.Location = new System.Drawing.Point(25, 345);
            this.CityNameTextBox.Name = "CityNameTextBox";
            this.CityNameTextBox.Size = new System.Drawing.Size(300, 28);
            this.CityNameTextBox.TabIndex = 23;
            this.CityNameTextBox.Text = "City Name ";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Enabled = false;
            this.SurnameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SurnameTextBox.Location = new System.Drawing.Point(380, 245);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(300, 28);
            this.SurnameTextBox.TabIndex = 22;
            this.SurnameTextBox.Text = "Surname";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameTextBox.Location = new System.Drawing.Point(25, 245);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(300, 28);
            this.NameTextBox.TabIndex = 21;
            this.NameTextBox.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Zip Code:";
            this.label2.UseWaitCursor = true;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(376, 410);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(162, 23);
            this.PhoneNumberLabel.TabIndex = 18;
            this.PhoneNumberLabel.Text = "Phone Number:";
            this.PhoneNumberLabel.UseWaitCursor = true;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.AutoSize = true;
            this.CityNameLabel.Location = new System.Drawing.Point(20, 310);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(119, 23);
            this.CityNameLabel.TabIndex = 16;
            this.CityNameLabel.Text = "City Name:";
            this.CityNameLabel.UseWaitCursor = true;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(376, 210);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(101, 23);
            this.SurnameLabel.TabIndex = 15;
            this.SurnameLabel.Text = "Surname:";
            this.SurnameLabel.UseWaitCursor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(20, 210);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 23);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name:";
            this.NameLabel.UseWaitCursor = true;
            // 
            // ModifyLabel
            // 
            this.ModifyLabel.AutoSize = true;
            this.ModifyLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModifyLabel.Location = new System.Drawing.Point(20, 164);
            this.ModifyLabel.Name = "ModifyLabel";
            this.ModifyLabel.Size = new System.Drawing.Size(92, 28);
            this.ModifyLabel.TabIndex = 3;
            this.ModifyLabel.Text = "Modify";
            this.ModifyLabel.UseWaitCursor = true;
            // 
            // IncorrectLoginLabel
            // 
            this.IncorrectLoginLabel.AutoSize = true;
            this.IncorrectLoginLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLoginLabel.Location = new System.Drawing.Point(20, 475);
            this.IncorrectLoginLabel.Name = "IncorrectLoginLabel";
            this.IncorrectLoginLabel.Size = new System.Drawing.Size(265, 19);
            this.IncorrectLoginLabel.TabIndex = 36;
            this.IncorrectLoginLabel.Text = "Login, which you entered is incorrect.";
            this.IncorrectLoginLabel.UseWaitCursor = true;
            this.IncorrectLoginLabel.Visible = false;
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Enabled = false;
            this.LogInTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogInTextBox.Location = new System.Drawing.Point(25, 445);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(300, 28);
            this.LogInTextBox.TabIndex = 35;
            this.LogInTextBox.Text = "Login";
            this.LogInTextBox.UseWaitCursor = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(20, 410);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(65, 23);
            this.LoginLabel.TabIndex = 34;
            this.LoginLabel.Text = "Login:";
            this.LoginLabel.UseWaitCursor = true;
            // 
            // IncorrectEmailLabel
            // 
            this.IncorrectEmailLabel.AutoSize = true;
            this.IncorrectEmailLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectEmailLabel.Location = new System.Drawing.Point(20, 575);
            this.IncorrectEmailLabel.Name = "IncorrectEmailLabel";
            this.IncorrectEmailLabel.Size = new System.Drawing.Size(266, 19);
            this.IncorrectEmailLabel.TabIndex = 46;
            this.IncorrectEmailLabel.Text = "Email, which you entered is incorrect.";
            this.IncorrectEmailLabel.UseWaitCursor = true;
            this.IncorrectEmailLabel.Visible = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailTextBox.Location = new System.Drawing.Point(25, 545);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(300, 28);
            this.EmailTextBox.TabIndex = 42;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.UseWaitCursor = true;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(20, 510);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(73, 23);
            this.EmailLabel.TabIndex = 39;
            this.EmailLabel.Text = "Email: ";
            this.EmailLabel.UseWaitCursor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(496, 730);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 40);
            this.CancelButton.TabIndex = 47;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmButton.Location = new System.Drawing.Point(350, 730);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(140, 40);
            this.ConfirmButton.TabIndex = 48;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(380, 93);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(300, 49);
            this.SearchButton.TabIndex = 49;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowClientDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.IncorrectEmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.IncorrectLoginLabel);
            this.Controls.Add(this.LogInTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.IncorrectZipCodeLabel);
            this.Controls.Add(this.IncorrectPhoneNumberLabel);
            this.Controls.Add(this.IncorrectCityNameLabel);
            this.Controls.Add(this.IncorrectSurnameLabel);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.ZipCodeTextBox1);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.CityNameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.CityNameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IncorrectPeselLabel);
            this.Controls.Add(this.PeselTextBox);
            this.Controls.Add(this.PeselLabel);
            this.Controls.Add(this.ModifyLabel);
            this.Controls.Add(this.ClientDetailsLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowClientDetailsUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientDetailsLabel;
        private System.Windows.Forms.Label IncorrectPeselLabel;
        private System.Windows.Forms.TextBox PeselTextBox;
        private System.Windows.Forms.Label PeselLabel;
        private System.Windows.Forms.Label IncorrectZipCodeLabel;
        private System.Windows.Forms.Label IncorrectPhoneNumberLabel;
        private System.Windows.Forms.Label IncorrectCityNameLabel;
        private System.Windows.Forms.Label IncorrectSurnameLabel;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.TextBox ZipCodeTextBox1;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox CityNameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label CityNameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ModifyLabel;
        private System.Windows.Forms.Label IncorrectLoginLabel;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label IncorrectEmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button SearchButton;
    }
}
