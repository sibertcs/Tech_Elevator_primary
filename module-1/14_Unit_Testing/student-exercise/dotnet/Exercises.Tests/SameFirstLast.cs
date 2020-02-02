using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void SameFirstLastTests()
        {
            SameFirstLast sameFirstLast = new SameFirstLast();
            bool result = sameFirstLast.IsItTheSame(new int[] { 1, 2, 1 });
            Assert.AreEqual(true, result);

            result = sameFirstLast.IsItTheSame(new int[] { 1, 2, 1, 5, 1 });
            Assert.AreEqual(true, result);

            result = sameFirstLast.IsItTheSame(new int[] { 1 });
            Assert.AreEqual(true, result);

            result = sameFirstLast.IsItTheSame(new int[] { 1, 2, 4 });
            Assert.AreEqual(false, result);

            result = sameFirstLast.IsItTheSame(new int[] { 1, 2 });
            Assert.AreEqual(false, result);
        }
    }
 }
