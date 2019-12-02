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
            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                if (AdminRadioButton.Checked)
                {
                    AdminForm adminMainForm = new AdminForm();
                    this.Hide();
                    adminMainForm.Show();
                }
                else
                {
                    ClientForm clientForm = new ClientForm();
                    this.Hide();
                    clientForm.Show();
                }
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            ResetControls();
            LogIn();
        }
    }
}
