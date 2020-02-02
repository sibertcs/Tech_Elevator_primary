using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void MaxEnd3Tests()
        {
            MaxEnd3 maxEnd = new MaxEnd3();
            int[] result = maxEnd.MakeArray(new int[] { 2, 3, 4 });
            CollectionAssert.AreEqual(new int[] { 4, 4, 4 }, result);

            result = maxEnd.MakeArray(new int[] { 9, 45, 7 });
            CollectionAssert.AreEqual(new int[] { 9, 9, 9 }, result);

            result = maxEnd.MakeArray(new int[] { 0, 0, 0 });
            CollectionAssert.AreEqual(new int[] { 0, 0, 0 }, result);

            result = maxEnd.MakeArray(new int[] { -12, -30, -6 });
            CollectionAssert.AreEqual(new int[] { -6, -6, -6 }, result);

            result = maxEnd.MakeArray(new int[] { -8, 55, -6 });
            CollectionAssert.AreEqual(new int[] { -6, -6, -6 }, result);

        }
    }
 }
