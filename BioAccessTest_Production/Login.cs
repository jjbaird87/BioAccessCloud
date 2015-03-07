using System;
using System.Collections.Generic;
using System.Linq;
using BioAccessTest_Production.BioAccessCloudBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BioAccessTest_Production
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void SuccessfulLogin()
        {
            var client = new BioAccessCloudBasicClient();
            var login = client.Login("jjbaird87", "biomaster");
            Assert.AreEqual(true, login.LoginSuccessful);
            Assert.AreNotSame("", login.SessionId);
        }

        [TestMethod]
        public void FailedLogin_IncorrectUsername()
        {
            var client = new BioAccessCloudBasicClient();
            var login = client.Login("manish", "biomaster");
            Assert.AreEqual("Username not found", login.ErrorMessage);
        }

        [TestMethod]
        public void FailedLogin_PasswordIncorrect()
        {
            var client = new BioAccessCloudBasicClient();
            var login = client.Login("jjbaird87", "wow");
            Assert.AreEqual("Password incorrect", login.ErrorMessage);
        }

        [TestMethod]
        public void GetSites()
        {
            var client = new BioAccessCloudBasicClient();
            var sites = client.GetSitesPerCustomer(2);
            foreach (var site in sites)
            {
                Console.WriteLine(site.SiteName);
                Console.ReadLine();
            }
            Assert.AreNotEqual(0,sites.Count());
        }

        [TestMethod]
        public void GetEmployeesPerSite()
        {
            var client = new BioAccessCloudBasicClient();
            var employees = client.GetEmployeesPerSite(5, true, "MorphoPkMat");
            var count = employees.Count();
            Assert.AreNotSame(0, employees.Count());
        }

        [TestMethod]
        public void CreateDummyTransaction()
        {
            var client = new BioAccessCloudBasicClient();
            var transactions = new List<DataStructuresAttendanceTransactionInBac>();
            transactions.Add(new DataStructuresAttendanceTransactionInBac
            {
                TransactionDateTime = "2014/01/01 02:00:00",
                Downloaded = false,
                Emei = "00000",
                EmployeeId = 2013,
                InOut = 1,
                Latitude = 0.765675,
                Longitude = 0.786876
            });
            client.InsertNewTransactions(transactions);
            Assert.AreEqual(0,0);
        }
    }
}
