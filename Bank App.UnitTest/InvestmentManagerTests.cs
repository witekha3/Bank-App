using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank_App.Classes;
using Bank_App.Forms;
using System.Data;

namespace Bank_App.UnitTest
{
    [TestClass]
    public class InvestmentManagerTests
    {
        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual30Days_InterestsIsCorrect()
        {
            string duration = "30 days";
            double interests = 0.010;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual60Days_InterestsIsCorrect()
        {
            string duration = "60 days";
            double interests = 0.030;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual90Days_InterestsIsCorrect()
        {
            string duration = "90 days";
            double interests = 0.055;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual180Days_InterestsIsCorrect()
        {
            string duration = "180 days";
            double interests = 0.08;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual360Days_InterestsIsCorrect()
        {
            string duration = "360 days";
            double interests = 0.12;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual720Days_InterestsIsCorrect()
        {
            string duration = "720 days";
            double interests = 0.26;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual1800Days_InterestsIsCorrect()
        {
            string duration = "1800 days";
            double interests = 0.9;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsEqual3600Days_InterestsIsCorrect()
        {
            string duration = "3600 days";
            double interests = 1.25;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }

        [TestMethod]
        public void MatchInterestToDuration_DurationIsIncorrect_InterestsIsEqualZero()
        {
            string duration = "";
            double interests = 0;

            InvestmentManager investmentManager = new InvestmentManager();
            double result = investmentManager.MatchInterestToDuration(duration);

            Assert.AreEqual(result, interests);
        }
        [TestMethod]
        public void CheckBalance_SaldoIsCorrect_ReturnsTrue()
        {
            LogInManager.WhoIsCurrentLoged = "test";
            string value = "10";
            DataBaseManager dataBaseManager = new DataBaseManager();

            string personTableQ = "INSERT INTO PersonTable VALUES(" + "'' ," +
                   "'" + "name" + "', '" + "Surname" + "', " +
                   "'" + "City" + "', '" + "ZipCode" + "', " +
                   "'" + "Email" + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " +
                   "'" + "PhoneNumber" + "', '" + "Pesel" + "');" +
                   "SELECT LAST_INSERT_ID();";

            string userTableQ = "INSERT INTO UserTable VALUES(" + "'' ," +
                    "'" + "Login" + "', '" + "Password" + "', 0); SELECT LAST_INSERT_ID();";


            DataTable personId = dataBaseManager.Get(personTableQ);
            DataTable userId = dataBaseManager.Get(userTableQ);

            string createAccountQ = "Insert into AccountTable values('', '" + personId.Rows[0].ItemArray[0].ToString() + "', '" + userId.Rows[0].ItemArray[0].ToString() + "', '" + "test" + "', '" + "100" + "')";
            dataBaseManager.Post(createAccountQ);


            InvestmentManager investmentManager = new InvestmentManager();
            bool result = investmentManager.CheckBalance(value);

            DataTable getId = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");

            AccountsManager accountsManager = new AccountsManager();
            accountsManager.DeleteClientFromDataBase(getId.Rows[0].ItemArray[0].ToString());

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckBalance_SaldoIsCorrect_ReturnsFalse()
        {
            LogInManager.WhoIsCurrentLoged = "test";
            string value = "1000";
            DataBaseManager dataBaseManager = new DataBaseManager();

            string personTableQ = "INSERT INTO PersonTable VALUES(" + "'' ," +
                   "'" + "name" + "', '" + "Surname" + "', " +
                   "'" + "City" + "', '" + "ZipCode" + "', " +
                   "'" + "Email" + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " +
                   "'" + "PhoneNumber" + "', '" + "Pesel" + "');" +
                   "SELECT LAST_INSERT_ID();";

            string userTableQ = "INSERT INTO UserTable VALUES(" + "'' ," +
                    "'" + "Login" + "', '" + "Password" + "', 0); SELECT LAST_INSERT_ID();";


            DataTable personId = dataBaseManager.Get(personTableQ);
            DataTable userId = dataBaseManager.Get(userTableQ);

            string createAccountQ = "Insert into AccountTable values('', '" + personId.Rows[0].ItemArray[0].ToString() + "', '" + userId.Rows[0].ItemArray[0].ToString() + "', '" + "test" + "', '" + "100" + "')";
            dataBaseManager.Post(createAccountQ);


            InvestmentManager investmentManager = new InvestmentManager();
            bool result = investmentManager.CheckBalance(value);

            DataTable getId = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");

            AccountsManager accountsManager = new AccountsManager();
            accountsManager.DeleteClientFromDataBase(getId.Rows[0].ItemArray[0].ToString());

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AddInvestment_InvestmentAdded()
        {
            LogInManager.WhoIsCurrentLoged = "test";
            string duration = "180 days";
            string name = "name";
            string type = "DAILY";
            string value = "10";

            InvestmentManager investmentManager = new InvestmentManager();
            investmentManager.AddInvestment(duration, name, type, value);
            DataBaseManager dataBaseManager = new DataBaseManager();
            DataTable result = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");

            Assert.IsNotNull(result);

            dataBaseManager.Post("delete from InvestmentTable where AccountNumber = "+"'"+LogInManager.WhoIsCurrentLoged+"'");
        }
        [TestMethod]
        public void RemoveInvestment_InvestmentRemovedSuccesfully()
        {
            LogInManager.WhoIsCurrentLoged = "test";
            string duration = "180 days";
            string name = "name";
            string type = "DAILY";
            string value = "10";

            InvestmentManager investmentManager = new InvestmentManager();
            investmentManager.AddInvestment(duration, name, type, value);
            DataBaseManager dataBaseManager = new DataBaseManager();
            DataTable getId = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");

            investmentManager.RemoveInvestment(Convert.ToInt32(getId.Rows[0].ItemArray[0]));

            DataTable result = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");
            Assert.AreEqual(result.Rows.Count,0);
        }
        [TestMethod]
        public void GetAllInvestmentsFromDataBase_GetAllInvestmentsSuccesfully()
        {
            LogInManager.WhoIsCurrentLoged = "test";

            DataBaseManager dataBaseManager = new DataBaseManager();
            InvestmentManager investmentManager = new InvestmentManager();
            DataTable result = investmentManager.GetAllInvestmentsFromDataBase();
            DataTable inv = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");

            Assert.AreEqual(result.Rows.Count, inv.Rows.Count);
        }
        [TestMethod]
        public void SetSaldo_ChangedSaldoSuccesfully()
        {
            LogInManager.WhoIsCurrentLoged = "test";
            string value = "10";
            decimal AddValue = 10;

            DataBaseManager dataBaseManager = new DataBaseManager();

            string personTableQ = "INSERT INTO PersonTable VALUES(" + "'' ," +
                   "'" + "name" + "', '" + "Surname" + "', " +
                   "'" + "City" + "', '" + "ZipCode" + "', " +
                   "'" + "Email" + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " +
                   "'" + "PhoneNumber" + "', '" + "Pesel" + "');" +
                   "SELECT LAST_INSERT_ID();";

            string userTableQ = "INSERT INTO UserTable VALUES(" + "'' ," +
                    "'" + "Login" + "', '" + "Password" + "', 0); SELECT LAST_INSERT_ID();";


            DataTable personId = dataBaseManager.Get(personTableQ);
            DataTable userId = dataBaseManager.Get(userTableQ);

            string createAccountQ = "Insert into AccountTable values('', '" + personId.Rows[0].ItemArray[0].ToString() + "', '" + userId.Rows[0].ItemArray[0].ToString() + "', '" + "test" + "', '" + value + "')";
            dataBaseManager.Post(createAccountQ);

            InvestmentManager investmentManager = new InvestmentManager();
            investmentManager.SetSaldo(AddValue,"test");

            DataTable FinalSaldo = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'" + "");
            Assert.AreEqual(Convert.ToDouble(FinalSaldo.Rows[0].ItemArray[4]), 20);

            DataTable getId = dataBaseManager.Get("select * from AccountTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");

            AccountsManager accountsManager = new AccountsManager();
            accountsManager.DeleteClientFromDataBase(getId.Rows[0].ItemArray[0].ToString());
        }
        [TestMethod]
        public void UpdateInvValue_UpdatedSaldoSuccesfully()
        {
            LogInManager.WhoIsCurrentLoged = "test";
            string duration = "180 days";
            string name = "name";
            string type = "DAILY";
            string value = "10";
            double val = 10;

            InvestmentManager investmentManager = new InvestmentManager();
            investmentManager.AddInvestment(duration, name, type, value);
            DataBaseManager dataBaseManager = new DataBaseManager();
            DataTable getId = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");

            investmentManager.UpdateInvestmentValue(Convert.ToInt32(getId.Rows[0].ItemArray[0]),val);

            getId = dataBaseManager.Get("select * from InvestmentTable where AccountNumber = " + "'" + LogInManager.WhoIsCurrentLoged + "'");

            double currentsaldo =Convert.ToDouble(getId.Rows[0].ItemArray[3]);
            investmentManager.RemoveInvestment(Convert.ToInt32(getId.Rows[0].ItemArray[0]));

            Assert.AreEqual(currentsaldo, val);
        }
    }
}
