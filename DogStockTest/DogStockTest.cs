using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuffedAnimalsShop;
using System;

namespace DogStockTest
{
    [TestClass]
    public class DogStockTest
    {
        [TestMethod]
        public void dogStockUnitTest()
        {
            var expected = 51;
            var stock = new Dog(9.5, 59);

            var shopStock = stock.DogStock(8);

            Assert.AreEqual(expected, shopStock);
        }
    }
}
