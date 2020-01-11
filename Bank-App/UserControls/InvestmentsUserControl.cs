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
        InvestmentManager investmentManager = new InvestmentManager();
        DataBaseManager dataBaseManager = new DataBaseManager();
        TransferManager transferManager = new TransferManager();

        public delegate void ChangedBalanceValueEventHandler(object o, EventArgs e);
        public event ChangedBalanceValueEventHandler ChangedBalanceValue;

        protected virtual void OnChangedBalanceValue()
        {
            if (ChangedBalanceValue != null)
                ChangedBalanceValue(this, EventArgs.Empty);
        }
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
                investmentManager.RemoveInvestment(Convert.ToInt32(id));
                DataTable SenderData = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
                investmentManager.Saldo = Convert.ToDecimal(SenderData.Rows[0]["Saldo"]);
                transferManager.UpdateBalance(investmentManager.Saldo, Convert.ToDecimal(value), '+');
                investmentManager.Saldo = 0.0M;
                OnChangedBalanceValue();
            }
            catch (ArgumentOutOfRangeException)
            {
                IncorrectSelectedItemLabel.Visible = true;
            }

        }
        private void Cancel()
        {
            ResetControls();
            investmentManager.Saldo = 0.0M;
            this.Parent.Controls["MainUserControl"].BringToFront();
        }

        private void Create()
        {
            ResetControls();
            investmentManager.Saldo = 0.0M;
            this.Parent.Controls["addingInvestmentUserControl"].BringToFront();
        }
        public void UpdateInvestmentList()
        {
             for (int k = InvestmentsList.Items.Count; k>0; k--)
             {
                InvestmentsList.Items[0].Remove();
             }

             DataTable MyInvestments = investmentManager.GetAllInvestmentsFromDataBase();
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
