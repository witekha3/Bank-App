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
    public partial class InvestmentsUserControl : UserControl
    {
        public InvestmentsUserControl()
        {
            InitializeComponent();
            UpdateInvestmentList();
        }
        private void ResetControls()
        {
            IncorrectSelectedItemLabel.Visible = false;
        }

        private void Delete()
        {

            ResetControls();

            try
            {
                string id = InvestmentsList.SelectedItems[0].SubItems[0].Text;
                string value = InvestmentsList.SelectedItems[0].SubItems[3].Text;
                InvestmentsList.SelectedItems[0].Remove();
                InvestmentManager.RemoveInvestment(Convert.ToInt32(id));
                DataTable SenderData = DataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
                InvestmentManager.Saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"]);
                TransferManager.UpdateBalance(InvestmentManager.Saldo, Convert.ToDecimal(value), '+');
                InvestmentManager.Saldo = 0.0M;
            }
            catch (ArgumentOutOfRangeException)
            {
                IncorrectSelectedItemLabel.Visible = true;
            }

        }
        private void Cancel()
        {
            ResetControls();
            InvestmentManager.Saldo = 0.0M;
            this.Parent.Controls["MainUserControl"].BringToFront();
        }

        private void Create()
        {
            ResetControls();
            InvestmentManager.Saldo = 0.0M;
            this.Parent.Controls["addingInvestmentUserControl"].BringToFront();
        }
        public void UpdateInvestmentList()
        {
             for (int k = InvestmentsList.Items.Count; k>0; k--)
             {
                InvestmentsList.Items[0].Remove();
             }

             DataTable MyInvestments = InvestmentManager.GetAllInvestmentsFromDataBase();
             ListView listView = new ListView();
             string[] str = new string[MyInvestments.Columns.Count - 1];
             int fc = MyInvestments.Columns.Count - 1;

             foreach (DataRow row in MyInvestments.Rows)
             {
                 string[] subitems = new string[fc];

                 object[] o = row.ItemArray;
                 for (int i = 0; i < fc; i++)
                 {
                     subitems[i] = o[i].ToString();
                 }
                 ListViewItem item = new ListViewItem(subitems);
                 InvestmentsList.Items.Add(item);
             }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateInvestmentList();
        }
    }
}
