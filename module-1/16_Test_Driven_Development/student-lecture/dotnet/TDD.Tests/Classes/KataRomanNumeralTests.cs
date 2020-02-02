using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Classes;

namespace TDD.Tests.Classes
{
    [TestClass]
    public class KataRomanNumeralTests
    {
        [TestMethod]
        public void RomanNumeralTest()
        {
            RomanNUMERAL romanNumerals = new RomanNUMERAL();
            string result = romanNumerals.romanNumeral(78);
            Assert.AreEqual("LXXVIII", result);

           
            result = romanNumerals.romanNumeral(5);
            Assert.AreEqual("V", result);

        }
        

        
    }
}
