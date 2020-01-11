using Bank_App.Classes;
using Bank_App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App
{
    public partial class LogInForm : Form
    {
        InvestmentManager investmentManager = new InvestmentManager();
        LogInManager logInManager = new LogInManager();
        public LogInForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetControls()
        {
            IncorrectLoginLabel.Visible = false;
            LogInTextBox.ForeColor = SystemColors.ControlDarkDark;
            LogInTextBox.BackColor = SystemColors.Window;

            IncorrectPasswordLabel.Visible = false;
            PasswordTextBox.ForeColor = SystemColors.ControlDarkDark;
            PasswordTextBox.BackColor = SystemColors.Window;
        }

        private bool CheckControls()
        {
            bool isConfirmed=true;

            if(LogInTextBox.Text == "")
            {
                IncorrectLoginLabel.Visible = true;
                LogInTextBox.ForeColor = Color.White;
                LogInTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if(PasswordTextBox.Text == "")
            {
                IncorrectPasswordLabel.Visible = true;
                PasswordTextBox.ForeColor = Color.White;
                PasswordTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (isConfirmed == true)
                return true;
            else
                return false;
 
        }

        private void LogIn()
        {
            ResetControls();

            bool isConfirmed = CheckControls();
            bool isAdmin;

            if (isConfirmed == true)
            {

                bool isUserExist = logInManager.LogIn(LogInTextBox.Text, PasswordTextBox.Text, out isAdmin);
                investmentManager.UpDateInvestments();

                if (isUserExist == true)

                {
                    if(isAdmin == true)
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        ClientForm clientForm = new ClientForm();
                        clientForm.Show();
                        this.Hide();
                    }

                }
                else
                {

                    IncorrectLoginLabel.Visible = true;
                    LogInTextBox.ForeColor = Color.White;
                    LogInTextBox.BackColor = Color.Red;

                    IncorrectPasswordLabel.Visible = true;
                    PasswordTextBox.ForeColor = Color.White;
                    PasswordTextBox.BackColor = Color.Red;

                }
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            DataBaseManager db = new DataBaseManager();
            db.Post("Insert into PersonTable Values('','admin','admin','admin','admin','admin','10 -10-2012', 'admin','admin')");
            db.Post("Insert into UserTable Values('', 'admin','admin','1')");
            db.Post("Insert into AccountTable Values('','1','1','admin','100')");





            //LogIn();
        }
    }
}
