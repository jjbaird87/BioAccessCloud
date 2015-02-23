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
    }
}
