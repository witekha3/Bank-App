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
    public partial class AccountDetailsUserControl : UserControl
    {
        AccountsManager accountsManager = new AccountsManager();
        public AccountDetailsUserControl()
        {
            InitializeComponent();
        }

        private void ShowAccountDetails()
        {
            DataTable data = accountsManager.GetAccountDetails();

            NameLabel.Text = "Name: " + data.Rows[0].ItemArray[2].ToString();
            SurnameLabel.Text = "Surname: " + data.Rows[0].ItemArray[3].ToString();
            DateOfBirthLabel.Text = "Date of Birth: " + data.Rows[0].ItemArray[4].ToString();
            PeselNumberLabel.Text = "Pesel: " + data.Rows[0].ItemArray[5].ToString();
            EmailLabel.Text = "Email: " + data.Rows[0].ItemArray[6].ToString();
            PhoneNumberLabel.Text = "Phone: " + data.Rows[0].ItemArray[7].ToString();
            CityLabel.Text = "City: " + data.Rows[0].ItemArray[8].ToString();
            ZipCodeLabel.Text = "Zip Code: " + data.Rows[0].ItemArray[9].ToString();
            LoginLabel.Text = "Login: " + data.Rows[0].ItemArray[1].ToString();
            AccountNumberLabel.Text = "Account Number: " + data.Rows[0].ItemArray[10].ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["MainUserControl"].BringToFront();
        }

        private void AccountDetailsUserControl_Load(object sender, EventArgs e)
        {
            ShowAccountDetails();
        }
    }
}
