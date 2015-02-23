using BioAccess_TEst.BioAccessCloudBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BioAccess_TEst
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
            Assert.AreEqual(1, login.CustomerId);
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
    }
}
