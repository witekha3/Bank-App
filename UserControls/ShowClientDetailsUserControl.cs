using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_App.Classes;

namespace Bank_App.UserControls
{
    public partial class ShowClientDetailsUserControl : UserControl
    {
        public ShowClientDetailsUserControl()
        {
            InitializeComponent();
        }

        private bool CheckPeselNumber()
        {
            if (PeselTextBox.Text == "")
            {
                IncorrectPeselLabel.Visible = true;
                PeselTextBox.ForeColor = Color.White;
                PeselTextBox.BackColor = Color.Red;
                return false;
            }
            else
                return true;
        }

        private void ResetPeselControls()
        {
            IncorrectPeselLabel.Visible = false;
            PeselTextBox.ForeColor = SystemColors.ControlDarkDark;
            PeselTextBox.BackColor = SystemColors.Window;
        }
        private bool CheckControls()
        {
            bool isConfirmed = true;

            if (NameTextBox.Text == "")
            {
                IncorrectNameLabel.Visible = true;
                NameTextBox.ForeColor = Color.White;
                NameTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (SurnameTextBox.Text == "")
            {
                IncorrectSurnameLabel.Visible = true;
                SurnameTextBox.ForeColor = Color.White;
                SurnameTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (CityNameTextBox.Text == "")
            {
                IncorrectCityNameLabel.Visible = true;
                CityNameTextBox.ForeColor = Color.White;
                CityNameTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (ZipCodeTextBox1.Text == "")
            {
                IncorrectZipCodeLabel.Visible = true;
                ZipCodeTextBox1.ForeColor = Color.White;
                ZipCodeTextBox1.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (LogInTextBox.Text == "")
            {
                IncorrectLoginLabel.Visible = true;
                LogInTextBox.ForeColor = Color.White;
                LogInTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (EmailTextBox.Text == "")
            {
                IncorrectEmailLabel.Visible = true;
                EmailTextBox.ForeColor = Color.White;
                EmailTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (isConfirmed == true)
                return true;
            else
                return false;
        }
        private void SetTextBoxesValue()
        {
            NameTextBox.Text = "Name";
            SurnameTextBox.Text = "Surname";
            CityNameTextBox.Text = "City Name";
            ZipCodeTextBox1.Text = "00-000";
            PeselTextBox.Text = "Pesel";
            PhoneNumberTextBox.Text = "PhoneNumber";
            LogInTextBox.Text = "Login";
            EmailTextBox.Text = "Email";
        }
        private void ResetControls()
        {
            IncorrectNameLabel.Visible = false;
            NameTextBox.ForeColor = SystemColors.ControlDarkDark;
            NameTextBox.BackColor = SystemColors.Window;

            IncorrectSurnameLabel.Visible = false;
            SurnameTextBox.ForeColor = SystemColors.ControlDarkDark;
            SurnameTextBox.BackColor = SystemColors.Window;

            IncorrectCityNameLabel.Visible = false;
            CityNameTextBox.ForeColor = SystemColors.ControlDarkDark;
            CityNameTextBox.BackColor = SystemColors.Window;

            IncorrectZipCodeLabel.Visible = false;
            ZipCodeTextBox1.ForeColor = SystemColors.ControlDarkDark;
            ZipCodeTextBox1.BackColor = SystemColors.Window;

            IncorrectEmailLabel.Visible = false;
            EmailTextBox.ForeColor = SystemColors.ControlDarkDark;
            EmailTextBox.BackColor = SystemColors.Window;

            IncorrectLoginLabel.Visible = false;
            LogInTextBox.ForeColor = SystemColors.ControlDarkDark;
            LogInTextBox.BackColor = SystemColors.Window;
        }
        private void SetVisibility(bool isVisible)
        {
            if (isVisible)
            {
                NameTextBox.Enabled = true;
                SurnameTextBox.Enabled = true;
                CityNameTextBox.Enabled = true;
                ZipCodeTextBox1.Enabled = true;
                LogInTextBox.Enabled = true;
                PhoneNumberTextBox.Enabled = true;
                EmailTextBox.Enabled = true;
                ConfirmButton.Enabled = true;
            }
            else
            {
                NameTextBox.Enabled = false;
                SurnameTextBox.Enabled = false;
                CityNameTextBox.Enabled = false;
                ZipCodeTextBox1.Enabled = false;
                LogInTextBox.Enabled = false;
                PhoneNumberTextBox.Enabled = false;
                EmailTextBox.Enabled = false;
                ConfirmButton.Enabled = false;
            }
        }

        private void FillTextBoxesByData(DataTable data)
        {
            try
            {
                LogInTextBox.Text = data.Rows[0].ItemArray[1].ToString();
                NameTextBox.Text = data.Rows[0].ItemArray[2].ToString();
                SurnameTextBox.Text = data.Rows[0].ItemArray[3].ToString();
                CityNameTextBox.Text = data.Rows[0].ItemArray[4].ToString();
                ZipCodeTextBox1.Text = data.Rows[0].ItemArray[5].ToString();
                PhoneNumberTextBox.Text = data.Rows[0].ItemArray[6].ToString();
                EmailTextBox.Text = data.Rows[0].ItemArray[7].ToString();
            }
            catch (ArgumentNullException)
            {
                SetVisibility(false);
            }

        }

        private void Search()
        {
            ResetControls();
            ResetPeselControls();
            SetVisibility(false);

            bool isConfirmed = true;
            isConfirmed = CheckPeselNumber();

            if(isConfirmed)
            {
                SetVisibility(true);
                try
                {
                    DataTable data = AccountsManager.GetUserDetailByAdmin(PeselTextBox.Text);
                    FillTextBoxesByData(data);

                }
                catch (IndexOutOfRangeException)
                {
                    IncorrectPeselLabel.Visible = true;
                }

            }

        }

        private void Back()
        {
            ResetControls();
            ResetPeselControls();
            SetVisibility(false);
            SetTextBoxesValue();

            this.Parent.Controls["mainUserControl"].BringToFront();
        }

        private void Confirm()
        {
            bool isConfirmed = true;
            isConfirmed = CheckControls();

            if(isConfirmed == true)
            {
                AccountsManager.UpdateUserDetails(PeselTextBox.Text, LogInTextBox.Text, NameTextBox.Text, SurnameTextBox.Text, CityNameTextBox.Text,
                    ZipCodeTextBox1.Text, EmailTextBox.Text, PhoneNumberTextBox.Text);
                ResetControls();
                ResetPeselControls();
                SetVisibility(false);
                SetTextBoxesValue();

                this.Parent.Controls["mainUserControl"].BringToFront();
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Confirm();
        }
    }
}
