using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_App.Forms;
using Bank_App.Classes;

namespace Bank_App.UserControls
{
    public partial class AddingClientUserControl1 : UserControl
    {
        public AddingClientUserControl1()
        {
            InitializeComponent();
        }

        private void ResetControls()
        {
            IncorrectLoginLabel.Visible = false;
            LogInTextBox.ForeColor = SystemColors.ControlDarkDark;
            LogInTextBox.BackColor = SystemColors.Window;

            IncorrectPasswordLabel1.Visible = false;
            PasswordTextBox.ForeColor = SystemColors.ControlDarkDark;
            PasswordTextBox.BackColor = SystemColors.Window;

            IncorrectRePasswordLabel.Visible = false;
            RePasswordTextBox.ForeColor = SystemColors.ControlDarkDark;
            RePasswordTextBox.BackColor = SystemColors.Window;

            IncorrectEmailLabel.Visible = false;
            EmailTextBox.ForeColor = SystemColors.ControlDarkDark;
            EmailTextBox.BackColor = SystemColors.Window;
        }

        private bool CheckControls()
        {
            bool isConfirmed = true;

            if(LogInTextBox.Text == "")
            {
                IncorrectLoginLabel.Visible = true;
                LogInTextBox.ForeColor = Color.White;
                LogInTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (PasswordTextBox.Text == "")
            {
                IncorrectPasswordLabel1.Visible = true;
                PasswordTextBox.ForeColor = Color.White;
                PasswordTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (RePasswordTextBox.Text == "")
            {
                IncorrectPasswordLabel2.Visible = true;
                RePasswordTextBox.ForeColor = Color.White;
                RePasswordTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (EmailTextBox.Text == "")
            {
                IncorrectEmailLabel.Visible = true;
                EmailTextBox.ForeColor = Color.White;
                EmailTextBox.BackColor = Color.Red;
                isConfirmed = false;
            }

            if (isConfirmed == true)
                return true;
            else
                return false;
        }

        private bool ComparePasswords()
        {
            ResetControls();

            bool arePasswordsSame = true;

            if(PasswordTextBox.Text != RePasswordTextBox.Text)
            {
                IncorrectRePasswordLabel.Visible = true;
                PasswordTextBox.ForeColor = Color.White;
                PasswordTextBox.BackColor = Color.Red;
                RePasswordTextBox.ForeColor = Color.White;
                RePasswordTextBox.BackColor = Color.Red;

                arePasswordsSame = false;
            }

            if (arePasswordsSame == true)
                return true;
            else
                return false;
        }

        private void SetTextBoxesValue()
        {
            LogInTextBox.Text = "Login";
            PasswordTextBox.Text = "Password";
            RePasswordTextBox.Text = "Password";
            EmailTextBox.Text = "Email";
        }

        private void Next()
        {
            ResetControls();

            AccountsManager.Client = null;
            bool isConfirmed = CheckControls();

            if (isConfirmed == true)
            {
                bool arePasswordsSame = ComparePasswords();

                if (arePasswordsSame == true)
                {
                    AccountsManager.Client = new Client(LogInTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text);
                    SetTextBoxesValue();
                    this.Parent.Controls["addingClientUserControl2"].BringToFront();
                }
            }
        }

        private void Cancel()
        {
            ResetControls();
            SetTextBoxesValue();
            this.Parent.Controls["mainUserControl"].BringToFront();
        }

        private void AcceptNumbersAndLettersAndAt(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@' && EmailTextBox.SelectionStart == 0)
                e.Handled = true;

            if (e.KeyChar == '@' && (sender as TextBox).Text.Contains('@'))
                e.Handled = true;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Next();            
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptNumbersAndLettersAndAt(sender, e);
        }
    }
}
