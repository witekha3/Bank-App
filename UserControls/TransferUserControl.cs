﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
            else
            {
                TitleTextBox.Enabled = false;
                ValueTextBox.Enabled = false;
                DatePicker.Enabled = false;
                AccountNumberTextBox.Enabled = false;
            }
        }

        private void Confirm()
        {
            bool isConfirmed = CheckControls();

            if(isConfirmed)
            {
                SetVisibility(false);
                ResetControls();
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

        private void SelectDefinedTransfer()
        {
            SetVisibility(false);
            ResetControls();
            SetValueOfTextBoxes();
            this.Parent.Controls["selectDefinedTransferUserControl"].BringToFront();
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
        }
    }
}
