using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank_App.Classes;
using Bank_App.Forms;

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
    }
}
