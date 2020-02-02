using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;



namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void TestAnimalWithLowerCaseArg()
        {
            AnimalGroupName animalGroup = new AnimalGroupName();
            string result = animalGroup.GetHerd("elephant");
            Assert.AreEqual("Herd", result);

        }
        [TestMethod]
        public void TestAnimalWithUpperCaseArg()
        {
            AnimalGroupName animalGroup = new AnimalGroupName();
            string result = animalGroup.GetHerd("Crow");
            Assert.AreEqual("Murder", result);
        }
        [TestMethod]
        public void TestAnimalWithEmptyArg()
        {
            AnimalGroupName animalGroup = new AnimalGroupName();
            string result = animalGroup.GetHerd("");
            Assert.AreEqual("unknown", result);
        }
        [TestMethod]
        public void TestAnimalWithNull()
        {
            AnimalGroupName animalGroup = new AnimalGroupName();
            string result = animalGroup.GetHerd(null);
            Assert.AreEqual("unknown", result);
        }
        [TestMethod]
        public void TestAnimalWithUknownAnimalArg()
        {
            AnimalGroupName animalGroup = new AnimalGroupName();
            string result = animalGroup.GetHerd("alligator");
            Assert.AreEqual("unknown", result);
        }
    }
}
