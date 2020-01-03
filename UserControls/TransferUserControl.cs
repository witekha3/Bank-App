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

            if (ValueTextBox.Text == "" || TransferManager.CheckBalance(ValueTextBox.Text) == false)
            {
                IncorrectValueLabel.Visible = true;
                ValueTextBox.ForeColor = Color.White;
                ValueTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if(AccountNumberTextBox.Text == "" || TransferManager.CheckIfExist(AccountNumberTextBox.Text) == false)
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
            ResetControls();
            bool isConfirmed = CheckControls(); 

            if (isConfirmed == true)
            {
                TransferManager.SendMoney(CreateTransfer());
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
            DefinedTransferTextBox.Text = "";
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

        private void SelectDefinedTransfer()
        {
            SetVisibility(false);
            ResetControls();
            SetValueOfTextBoxes();
            this.Parent.Controls["selectDefinedTransferUserControl"].BringToFront();
        }
        private void DefinedTransfer()
        {
            AutoCompleteStringCollection myCollection = TransferManager.DefinedTransfer();

            DefinedTransferTextBox.AutoCompleteCustomSource = myCollection;
        }

        private void DefinedTransferPrompt(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DataTable data = TransferManager.GetDataRelatedToDefinedTransfers(DefinedTransferTextBox.Text);

                TitleTextBox.Text = data.Rows[0].ItemArray[0].ToString();
                ValueTextBox.Text = data.Rows[0].ItemArray[1].ToString();
                AccountNumberTextBox.Text = data.Rows[0].ItemArray[2].ToString();
                SetVisibility(true);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
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

        private void TransferUserControl_Load(object sender, EventArgs e)
        {
            DefinedTransfer();
        }

        private void DefinedTransferTxt_KeyDown(object sender, KeyEventArgs e)
        {
            DefinedTransferPrompt(e);
        }

        private void DefinedTransferTxt_Click(object sender, EventArgs e)
        {
            DefinedTransfer();
        }
    }
}
