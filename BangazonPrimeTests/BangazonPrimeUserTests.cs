using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BangazonPrimeTests
{
    [TestClass]
    public class BangazonPrime
    {
        [TestMethod]
        public void UserIsBangazonPrimeUser()
        {
            User bangazonUser = new User(DateTime.Now.AddMonths(-1), null, 123);//no end date means they have Bangazon prime
            bool userIsPrime = bangazonUser.IsPrimeUser;
            Assert.IsTrue(userIsPrime);
        }

        [TestMethod]
        public void UserIsNotBangazonPrimeUser()
        {
            User bangazonUser = new User(DateTime.Now.AddMonths(-11), DateTime.Now.AddMonths(-1), 344); //End Date in the past means no Bangazon prime
            bool userIsPrime = bangazonUser.IsPrimeUser;
            Assert.IsFalse(userIsPrime);
        }
    }
}
