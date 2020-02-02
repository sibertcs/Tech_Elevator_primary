using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void Lucky13Tests()
        {
            Lucky13 lucky13 = new Lucky13();
            bool result = lucky13.GetLucky( new int[] { 1, 2, 3});
            Assert.AreEqual(false, result);

            result = lucky13.GetLucky(new int[] { 0, 2, 14 });
            Assert.AreEqual(true, result);

            result = lucky13.GetLucky(new int[] { 1, 3, 3 });
            Assert.AreEqual(false, result);

            result = lucky13.GetLucky(new int[] { 4, 6, 7 });
            Assert.AreEqual(true, result);

            result = lucky13.GetLucky(new int[] { 0, 11, 33  });
            Assert.AreEqual(true, result);



        }
}   }
