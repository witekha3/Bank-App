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
    public partial class AddingClientUserControl2 : UserControl
    {
        AccountsManager accountsManager = new AccountsManager();

        public AddingClientUserControl2()
        {
            InitializeComponent();
            DateOfBirthPicker.MaxDate = DateTime.Now;
            DateOfBirthPicker.Value = DateTime.Now;
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

            IncorrectPeselLabel.Visible = false;
            PeselTextBox.ForeColor = SystemColors.ControlDarkDark;
            PeselTextBox.BackColor = SystemColors.Window;

            IncorrectClientLabel.Visible = false;

        }
        private void SetTextBoxesValue()
        {
            NameTextBox.Text = "Name";
            SurnameTextBox.Text = "Surname";
            CityNameTextBox.Text = "City Name";
            ZipCodeTextBox1.Text = "00-000";
            PeselTextBox.Text = "Pesel";
            PhoneNumberTextBox.Text = "PhoneNumber";
            DateOfBirthPicker.MaxDate = DateTime.Today;
            DateOfBirthPicker.Value = DateTime.Today;
        }

        private bool CheckControls()
        {
            bool isConfirmed = true;

            if(NameTextBox.Text == "")
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

            if(ZipCodeTextBox1.Text == "")
            {
                IncorrectZipCodeLabel.Visible = true;
                ZipCodeTextBox1.ForeColor = Color.White;
                ZipCodeTextBox1.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (PeselTextBox.Text == "")
            {
                IncorrectPeselLabel.Visible = true;
                PeselTextBox.ForeColor = Color.White;
                PeselTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (isConfirmed == true)
                return true;
            else
                return false;
        }

        private void CreateClient()
        {
            ResetControls();

            bool isConfirmed = CheckControls();

            if(isConfirmed == true)
            {
                bool isExist = accountsManager.CheckIfPersonExist(AccountsManager.Client.Pesel);

                if(isExist == false)
                {
                    AccountsManager.Client.AccountNumber = accountsManager.GenerateAccountNumber();
                    AccountsManager.Client.Name = NameTextBox.Text;
                    AccountsManager.Client.Surname = SurnameTextBox.Text;
                    AccountsManager.Client.City = CityNameTextBox.Text;
                    AccountsManager.Client.ZipCode = ZipCodeTextBox1.Text;
                    AccountsManager.Client.DateOfBirth = DateOfBirthPicker.Value.Date;
                    AccountsManager.Client.PhoneNumber = PhoneNumberTextBox.Text;
                    AccountsManager.Client.Pesel = PeselTextBox.Text;

                    accountsManager.CreateAccount();

                    SetTextBoxesValue();
                    ResetControls();
                    AccountsManager.Client = null;
                    this.Parent.Controls["mainUserControl"].BringToFront();
                }
                else
                {
                    IncorrectClientLabel.Visible = true;
                }

            }
        }

        private void Cancel()
        {
            ResetControls();
            this.Parent.Controls["addingClientUserControl1"].BringToFront();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            CreateClient();
        }

    }
}
