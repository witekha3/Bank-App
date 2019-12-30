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
using Bank_App.Forms;

namespace Bank_App.UserControls
{
    public partial class TransferUserControl : UserControl
    {
        public TransferUserControl()
        {
            InitializeComponent();
            DatePicker.MaxDate = DateTime.Now.AddMonths(1200);
            DatePicker.MinDate = DateTime.Now;
            DatePicker.Value = DateTime.Now;
        }

        private void ResetControls()
        {
            IncorrectTitleLabel.Visible = false;
            TitleTextBox.ForeColor = SystemColors.ControlDarkDark;
            TitleTextBox.BackColor = SystemColors.Window;

            IncorrectValueLabel.Visible = false;
            ValueTextBox.ForeColor = SystemColors.ControlDarkDark;
            ValueTextBox.BackColor = SystemColors.Window;
        }

        private bool CheckControls()
        {
            bool isConfirmed = true;

            if (TitleTextBox.Text == "")
            {
                IncorrectTitleLabel.Visible = true;
                TitleTextBox.ForeColor = Color.White;
                TitleTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (ValueTextBox.Text == "")
            {
                IncorrectValueLabel.Visible = true;
                ValueTextBox.ForeColor = Color.White;
                ValueTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if(AccountNumberTextBox.Text == "")
            {
                IncorrectAccountNumberLabel.Visible = true;
                AccountNumberTextBox.ForeColor = Color.White;
                AccountNumberTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (isConfirmed)
                return true;
            else
                return false;
        }

        private void SetVisibility(bool isVisible)
        {
            if(isVisible)
            {
                TitleTextBox.Enabled = true;
                ValueTextBox.Enabled = true;
                DatePicker.Enabled = true;
                AccountNumberTextBox.Enabled = true;
                ConfirmButton.Enabled = true;
            }
            else
            {
                TitleTextBox.Enabled = false;
                ValueTextBox.Enabled = false;
                DatePicker.Enabled = false;
                AccountNumberTextBox.Enabled = false;
                ConfirmButton.Enabled = false;
            }
        }

        private void Confirm()
        {
            bool isConfirmed = CheckControls();

            if(isConfirmed)
            {
                SetVisibility(false);
                ResetControls();
                SetValueOfTextBoxes();
                this.Parent.Controls["MainUserControl"].BringToFront();
            }
        }

        private void SetValueOfTextBoxes()
        {
            TitleTextBox.Text = "Title";
            ValueTextBox.Text = "0";
            AccountNumberTextBox.Text = "0";
        }

        private void Cancel()
        {
            SetVisibility(false);
            ResetControls();
            SetValueOfTextBoxes();
            this.Parent.Controls["MainUserControl"].BringToFront();
        }
        private Transfer CreateTransfer()
        {
            Transfer transfer = new Transfer(
                TitleTextBox.Text,
                Convert.ToDecimal(ValueTextBox.Text),
                LogInManager.WhoIsCurrentLoged,
                AccountNumberTextBox.Text,
                DatePicker.Value.Date);
            return transfer;
        }
        private bool CheckIfExist()
        {
            DataTable ReceiverData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + AccountNumberTextBox.Text + "'" + "");
            if (ReceiverData.Rows.Count != 0) return true;
            else
            {
                MessageBox.Show("Wrong receiver account number");
                return false;
            }
        }
        private bool CheckBalance()
        {
            DataTable SenderData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            decimal saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"]);
            if (saldo >= Convert.ToDecimal(ValueTextBox.Text)) 
            {
                return true;
            }
            else
            {
                MessageBox.Show("You don't have enough money to realize this transfer");
                return false;
            }
        }

        private void SelectDefinedTransfer()
        {
            SetVisibility(false);
            ResetControls();
            SetValueOfTextBoxes();
            this.Parent.Controls["selectDefinedTransferUserControl"].BringToFront();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CheckIfExist() && CheckBalance())
            {
                TransferManager.SendMoney(CreateTransfer());
            }
            Confirm();
        }

        private void DefinedTransferButton_Click(object sender, EventArgs e)
        {
            SelectDefinedTransfer();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void CreateTransferButton_Click(object sender, EventArgs e)
        {
            SetVisibility(true);
            SetValueOfTextBoxes();
        }

        private void DefinedTransfer()
        {
            AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();

            DataTable data = DataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber from TransferHistory where SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged);

            for (int i = 0; i < data.Rows.Count; i++) 
            {
                string sData = "";
                sData += data.Rows[i].ItemArray[0].ToString() + " Receiver Account: " + data.Rows[i].ItemArray[2].ToString();

                myCollection.Add(sData);
            }

            DefinedTransferTxt.AutoCompleteCustomSource = myCollection;
        }

        private void TransferUserControl_Load(object sender, EventArgs e)
        {
            DefinedTransfer();
        }

        private void DefinedTransferTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string selectedTransfer = DefinedTransferTxt.Text;
                int indexOfTitle = selectedTransfer.IndexOf(" Receiver Account: ");

                DataTable data = DataBaseManager.Get("Select Title, TransferValue, ReceiverAccountNumber from TransferHistory where " +
                    "SenderAccountNumber = " + LogInManager.WhoIsCurrentLoged + " and Title = '" + selectedTransfer.Substring(0, indexOfTitle)+"'");

                TitleTextBox.Text = data.Rows[0].ItemArray[0].ToString();
                ValueTextBox.Text = data.Rows[0].ItemArray[1].ToString();
                AccountNumberTextBox.Text = data.Rows[0].ItemArray[2].ToString();
                SetVisibility(true);
            }
        }
    }
}
