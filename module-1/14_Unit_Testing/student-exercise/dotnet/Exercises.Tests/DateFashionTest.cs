using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void DateFashionTests()
        {
            DateFashion dateFashion = new DateFashion();
            int result = dateFashion.GetATable(10, 6);
            Assert.AreEqual(2, result);

            result = dateFashion.GetATable(8, 3);
            Assert.AreEqual(2, result);

            result = dateFashion.GetATable(7, 6);
            Assert.AreEqual(1, result);

            result = dateFashion.GetATable(3, 6);
            Assert.AreEqual(1, result);

            result = dateFashion.GetATable(10, 2);
            Assert.AreEqual(0, result);

            result = dateFashion.GetATable(7, 2);
            Assert.AreEqual(0, result);

            result = dateFashion.GetATable(1, 2);
            Assert.AreEqual(0, result);

        }
    }
}
