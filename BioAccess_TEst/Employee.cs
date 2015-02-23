using System;
using BioAccess_TEst.BioAccessCloudBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BioAccess_TEst
{
    [TestClass]
    public class Employee
    {
        [TestMethod]
        public void GetEmployee()
        {
            var client = new BioAccessCloudBasicClient();
            var employees = client.GetEmployeesPerSite(1);
            client.Close();

            Assert.AreNotEqual(0, employees.Count);
        }

        [TestMethod]
        public void GetEmployeePerSite()
        {
            var client = new BioAccessCloudBasicClient();
            var employees = client.GetEmployeesPerSite(5);
            client.Close();

            Assert.AreNotEqual(0, employees.Count);
        }
    }
}
