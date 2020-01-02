using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_App.Enums;
using Bank_App.Forms;
using Bank_App.Classes;

namespace Bank_App.UserControls
{
    public partial class AddingInvestmentUserControl : UserControl
    {
        InvestmentTypes[] investmentTypesTab = new InvestmentTypes[4];
        public AddingInvestmentUserControl()
        {
            InitializeComponent();

            TypeComboBox.Items.Add(InvestmentTypes.DAILY.ToString());
            TypeComboBox.Items.Add(InvestmentTypes.TERM.ToString());
            TypeComboBox.Items.Add(InvestmentTypes.PROGRESS.ToString());
            TypeComboBox.Items.Add(InvestmentTypes.CURRENCY.ToString());
            TypeComboBox.Text = InvestmentTypes.DAILY.ToString();

            investmentTypesTab[0] = InvestmentTypes.DAILY;
            investmentTypesTab[1] = InvestmentTypes.TERM;
            investmentTypesTab[2] = InvestmentTypes.PROGRESS;
            investmentTypesTab[3] = InvestmentTypes.CURRENCY;

            DurationComboBox.Items.Add("30 days");
            DurationComboBox.Items.Add("60 days");
            DurationComboBox.Items.Add("90 days");
            DurationComboBox.Items.Add("180 days");
            DurationComboBox.Items.Add("360 days");
            DurationComboBox.Items.Add("720 days");
            DurationComboBox.Items.Add("1800 days");
            DurationComboBox.Items.Add("3600 days");
            DurationComboBox.Text = "30 days";
        }
        private decimal saldo;
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

            if (ValueTextBox.Text == "")
            {
                IncorrectValueLabel.Visible = true;
                ValueTextBox.ForeColor = Color.White;
                ValueTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (isConfirmed)
                return true;
            else
                return false;
        }

        private void ResetControls()
        {
            IncorrectNameLabel.Visible = false;
            NameTextBox.ForeColor = SystemColors.ControlDarkDark;
            NameTextBox.BackColor = SystemColors.Window;

            IncorrectValueLabel.Visible = false;
            ValueTextBox.ForeColor = SystemColors.ControlDarkDark;
            ValueTextBox.BackColor = SystemColors.Window;
        }
        private void SetTextBoxesValue()
        {
            NameTextBox.Text = "Name";
            ValueTextBox.Text = "Value";
            DurationComboBox.Text = "30 days";
            TypeComboBox.Text = InvestmentTypes.DAILY.ToString();
        }

        private double MatchInterestToDuration()
        {
            double interest = 0;

            if(DurationComboBox.Text == "30 days")
            {
                interest = 0.10;
                return interest;
            }

            else if (DurationComboBox.Text == "60 days")
            {
                interest = 0.30;
                return interest;
            }

            else if (DurationComboBox.Text == "90 days")
            {
                interest = 0.55;
                return interest;
            }

            else if (DurationComboBox.Text == "180 days")
            {
                interest = 0.8;
                return interest;
            }

            else if (DurationComboBox.Text == "360 days")
            {
                interest = 1.2;
                return interest;
            }

            else if (DurationComboBox.Text == "720 days")
            {
                interest = 2.6;
                return interest;
            }

            else if (DurationComboBox.Text == "1800 days")
            {
                interest = 9;
                return interest;
            }

            else if (DurationComboBox.Text == "3600 days")
            {
                interest = 12.5;
                return interest;
            }

            else
                return interest;

        }
        private void AddInvestment()
        {
            double interest = MatchInterestToDuration();
            DataBaseManager.Post("INSERT INTO InvestmentTable VALUES(" + "''," +
               "'" + NameTextBox.Text + "', '" + TypeComboBox.Text + "', " +
               "'" + ValueTextBox.Text.Replace(",", ".") + "', '" + interest.ToString() + "', " +
               "'" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddDays(Convert.ToInt32(DurationComboBox.Text.Replace(" days", ""))).ToString("yyyy-MM-dd") + "', '" + DurationComboBox.Text + "', " +
               "'" + LogInManager.WhoIsCurrentLoged + "')");
        }
        private bool CheckBalance()
        {
            DataTable SenderData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"]);
            if (saldo >= Convert.ToDecimal(ValueTextBox.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("You don't have enough money to realize this investment");
                return false;
            }
        }
        private void Confirm()
        {
            ResetControls();
            bool isConfirmed = CheckControls();

            if(isConfirmed == true)
            {
                if (CheckBalance())
                {
                    AddInvestment();
                    TransferManager.UpdateBalance(saldo,Convert.ToDecimal(ValueTextBox.Text),'-');
                    ResetControls();
                    SetTextBoxesValue();
                    this.Parent.Controls["mainUserControl"].BringToFront();
                }
            }
        }

        private void Cancel()
        {
            ResetControls();
            SetTextBoxesValue();
            this.Parent.Controls["investmentsUserControl"].BringToFront();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Confirm();
        }
    }
}
