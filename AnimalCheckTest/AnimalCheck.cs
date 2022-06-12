using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuffedAnimalsShop;
using System;

namespace AnimalCheckTest
{
    [TestClass]
    public class AnimalCheck
    {
        [TestMethod]
        public void AnimalTypeTest()
        {
            var expected = "Cat";
            var animal = new Cat();

            var animalType = animal.ExtraType();

            Assert.AreEqual<string>(expected, animalType);
        }
    }
}
