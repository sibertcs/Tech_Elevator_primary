using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]
        public void Less20Tests()
        {
            Less20 less20 = new Less20();
            bool result = less20.IsLessThanMultipleOf20(15);
            Assert.AreEqual(false, result);

            result = less20.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, result);

            result = less20.IsLessThanMultipleOf20(30);
            Assert.AreEqual(false, result);

            result = less20.IsLessThanMultipleOf20(39);
            Assert.AreEqual(true, result);

            result = less20.IsLessThanMultipleOf20(0);
            Assert.AreEqual(false, result);

        }
 }  }
