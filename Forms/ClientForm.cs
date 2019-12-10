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

        private void CreateControls()
        {
            MainUserControl mainUserControl = new MainUserControl();
            mainUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(mainUserControl);

            TransferUserControl transferUserControl = new TransferUserControl();
            transferUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(transferUserControl);

            AccountDetailsUserControl accountDetailsUserControl = new AccountDetailsUserControl();
            accountDetailsUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(accountDetailsUserControl);

            DefinedTransferUserControl definedTransferUserControl = new DefinedTransferUserControl();
            definedTransferUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(definedTransferUserControl);

            InvestmentsUserControl investmentsUserControl = new InvestmentsUserControl();
            investmentsUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(investmentsUserControl);

            AddingInvestmentUserControl addingInvestmentUserControl = new AddingInvestmentUserControl();
            addingInvestmentUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addingInvestmentUserControl);

            SelectDefinedTransferUserControl selectDefinedTransferUserControl = new SelectDefinedTransferUserControl();
            selectDefinedTransferUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(selectDefinedTransferUserControl);
        }

        private void LogOut()
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
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
    }
}
