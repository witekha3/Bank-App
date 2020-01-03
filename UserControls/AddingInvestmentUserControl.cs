﻿using System;
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
        InvestmentManager investmentManager = new InvestmentManager();
        TransferManager transferManager = new TransferManager();
        InvestmentTypes[] investmentTypesTab = new InvestmentTypes[4];
        public AddingInvestmentUserControl()
        {
            InitializeComponent();

            TypeComboBox.Items.Add("Daily");
            TypeComboBox.Items.Add("Term");
            TypeComboBox.Items.Add("Progress");
            TypeComboBox.Items.Add("Curerency");
            TypeComboBox.Text = "Daily";

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

            if (isConfirmed == true)
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

            IncorrectBalanceLabel.Visible = false;
        }
        private void SetTextBoxesValue()
        {
            NameTextBox.Text = "Name";
            ValueTextBox.Text = "Value";
            DurationComboBox.Text = "30 days";
            TypeComboBox.Text = "Daily";
        }

        private void Confirm()
        {
            ResetControls();
            bool isConfirmed = CheckControls();

            if(isConfirmed == true)
            {
                isConfirmed = investmentManager.CheckBalance(ValueTextBox.Text);

                if (isConfirmed == true)
                {
                    investmentManager.AddInvestment(DurationComboBox.Text, NameTextBox.Text, TypeComboBox.Text, ValueTextBox.Text);
                    transferManager.UpdateBalance(investmentManager.Saldo, Convert.ToDecimal(ValueTextBox.Text),'-');
                    ResetControls();
                    SetTextBoxesValue();
                    investmentManager.Saldo = 0.0M;
                    this.Parent.Controls["mainUserControl"].BringToFront();
                }
                else
                {
                    IncorrectBalanceLabel.Visible = true;
                }
            }
        }

        private void Cancel()
        {
            ResetControls();
            SetTextBoxesValue();
            investmentManager.Saldo = 0.0M;
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
