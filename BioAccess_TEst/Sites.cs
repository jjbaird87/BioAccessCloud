using System.Collections.Generic;
using BioAccess_TEst.BioAccessCloudBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BioAccess_TEst
{
    [TestClass]
    public class Sites
    {
        [TestMethod]
        public void GetSites()
        {
            var client = new BioAccessCloudBasicClient();
            var sites = client.GetSitesPerCustomer(1);            
            client.Close();
            Assert.AreNotEqual(0, sites.Count);
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
            Assert.AreEqual(0, 0);
        }
    }
}
