using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
   
    
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void FrontTimesTests()
        {
            FrontTimes frontTimes = new FrontTimes();
            string result = frontTimes.GenerateString("Programming", 2);
            Assert.AreEqual("ProPro", result);

            result = frontTimes.GenerateString("Programming", 3);
            Assert.AreEqual("ProProPro", result);


            result = frontTimes.GenerateString("Car", 2);
            Assert.AreEqual("CarCar", result);

            result = frontTimes.GenerateString("Hi", 2);
            Assert.AreEqual("HiHi", result);

            result = frontTimes.GenerateString(null, 3);
            Assert.AreEqual(null, result);
        }
    }
    
}
