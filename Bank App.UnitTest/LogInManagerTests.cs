using System;
using Bank_App.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank_App.UnitTest
{
    [TestClass]
    public class LogInManagerTests
    {
        [TestMethod]
        public void LogIn_IsLogedProperly_ReturnsTrue()
        {
            var logInManager = new LogInManager();
            string login = "admin";
            string password = "admin";
            bool isAdmin;

            bool result = logInManager.LogIn(login, password, out isAdmin);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void LogIn_IsLogedImproperly_ReturnsFalse()
        {
            var logInManager = new LogInManager();
            string login = "admin";
            string password = "wrongPassword";
            bool isAdmin;

            bool result = logInManager.LogIn(login, password, out isAdmin);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LogIn_IsLogedProperlyAndIsAdmin_ReturnsTrue()
        {
            var logInManager = new LogInManager();
            string login = "admin";
            string password = "admin";
            bool isAdmin;

            bool result = logInManager.LogIn(login, password, out isAdmin);

            Assert.IsTrue(isAdmin);
        }

        [TestMethod]
        public void LogIn_IsLogedProperlyAndIsClient_ReturnsFalse()
        {
            var logInManager = new LogInManager();
            string login = "user";
            string password = "user";
            bool isAdmin;

            bool result = logInManager.LogIn(login, password, out isAdmin);

            Assert.IsFalse(isAdmin);
        }
    }
}
