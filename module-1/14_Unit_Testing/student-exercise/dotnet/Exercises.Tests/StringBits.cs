using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void StringBitsTests()
        {
            StringBits stringBits = new StringBits();
            string result = stringBits.GetBits("Hello");
            Assert.AreEqual("Hlo", result);

            result = stringBits.GetBits(null);
            Assert.AreEqual(null, result);

            result = stringBits.GetBits("L");
            Assert.AreEqual("L", result);

            result = stringBits.GetBits("Hi");
            Assert.AreEqual("H", result);

            result = stringBits.GetBits("");
            Assert.AreEqual("", result);


        }
    }
}
