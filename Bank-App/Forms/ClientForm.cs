﻿using Bank_App.Classes;
using Bank_App.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App.Forms
{
    public partial class ClientForm : Form
    {
        private ClientForm instance;
        AccountsManager accountsManager = new AccountsManager();
        TransferManager transferManager = new TransferManager();
        
        public ClientForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientForm();
                }

                return instance;
            }
        }
        public ClientForm()
        {
            InitializeComponent();
            CreateControls();

            CentralPanel.Controls["MainUserControl"].BringToFront();
        }

        public void RefreshBalanceLabel(object o, EventArgs e)
        {
            decimal balance = accountsManager.GetUserAccountBalance();

            BalanceLabel.Text = "Balance: " + balance.ToString("C");
        }

        private void CreateControls()
        {
            MainUserControl mainUserControl = new MainUserControl();
            mainUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(mainUserControl);

            TransferUserControl transferUserControl = new TransferUserControl();
            transferUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(transferUserControl);
            transferUserControl.ChangedBalanceValue += RefreshBalanceLabel;

            AccountDetailsUserControl accountDetailsUserControl = new AccountDetailsUserControl();
            accountDetailsUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(accountDetailsUserControl);

            DefinedTransferUserControl definedTransferUserControl = new DefinedTransferUserControl();
            definedTransferUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(definedTransferUserControl);

            InvestmentsUserControl investmentsUserControl = new InvestmentsUserControl();
            investmentsUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(investmentsUserControl);
            investmentsUserControl.ChangedBalanceValue += RefreshBalanceLabel;

            AddingInvestmentUserControl addingInvestmentUserControl = new AddingInvestmentUserControl();
            addingInvestmentUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addingInvestmentUserControl);
            addingInvestmentUserControl.ChangedBalanceValue += RefreshBalanceLabel;

        }

        private void LogOut()
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            AccountNumberLabel.Text = "";
            this.Hide();
        }

        private void TransfersButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["transferUserControl"].BringToFront();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void AccountDetailsButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["accountDetailsUserControl"].BringToFront();
        }

        private void InvestmentsButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["investmentsUserControl"].BringToFront();
        }

        private void DefinedTransfersButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["definedTransferUserControl"].BringToFront();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            decimal balance = accountsManager.GetUserAccountBalance();

            AccountNumberLabel.Text = LogInManager.WhoIsCurrentLoged;

            BalanceLabel.Text = "Balance: " + balance.ToString("C");
        }
    }
}
