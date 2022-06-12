using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuffedAnimalsShop;
using System;

namespace UnitTestStuffedAnimals
{
    [TestClass()]
    public class DogTest
    {
        public DogTest()
        {
        }

        [TestMethod()]
        public void dogstockTest()
        {
            var expected = 88;
            var stock = new Dog();

            var actual = stock.DogStock(89, 1);

            Assert.AreEqual(expected, actual);
        }
    }
}
