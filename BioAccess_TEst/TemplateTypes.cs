using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BioAccess_TEst.BioAccessCloudBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BioAccess_TEst
{
    [TestClass]
    public class TemplateTypes
    {
        [TestMethod]
        public void GetTemplateTypes()
        {            
            var client = new BioAccessCloudBasicClient();
            var types = client.GetTemplateTypes();                      
            client.Close();

            Assert.AreNotEqual(types.Count, 0);
            var iso = types.Find(i => i.Description == "Iso");
            Assert.AreNotEqual(null,iso);
        }
    }
}
