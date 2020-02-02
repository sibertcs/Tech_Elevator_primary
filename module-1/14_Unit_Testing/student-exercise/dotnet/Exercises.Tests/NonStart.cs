using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void NonStartTests()
        {
            NonStart nonStart = new NonStart();
            string result = nonStart.GetPartialString("Computer", "Programmer");
            Assert.AreEqual("omputerrogrammer", result);

            result = nonStart.GetPartialString("Shotl", "java");
            Assert.AreEqual("hotlava", result);

            result = nonStart.GetPartialString("hi", "my");
            Assert.AreEqual("iy", result);
          

            result = nonStart.GetPartialString("", "pl");
            Assert.AreEqual("l", result);


        }
}   }
