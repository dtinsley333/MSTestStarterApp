using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BangazonPrimeTests
{
    [TestClass]
    class BangazonProductTests
    {
        [TestMethod]
        public void ProductIsBangazonPrimeEligible()
        {
            Product bangazonProduct = new Product(productId);
            bool isPrimeProduct = bangazonProduct.IsPrimeProduct;
            Assert.IsTrue(isPrimeProduct);
        }

        [TestMethod]
        public void ProductIsNotBangazonPrimeEligible()
        {
            Product bangazonProduct = new Product(productId);
            bool isPrimeProduct = bangazonProduct.IsPrimeProduct;
            Assert.IsFalse(isPrimeProduct);
        }

    }
}
