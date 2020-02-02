using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void WordCountTests()
        {
            WordCount wordCount = new WordCount();
            Dictionary<string, int> result = wordCount.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "ba", 2 }, { "black" , 1 }, { "sheep" , 1 } }, result);

            result = wordCount.GetCount(new string[] { "marco", "polo", "marco", "polo" });
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "marco", 2 }, { "polo", 2 } }, result);

            result = wordCount.GetCount(new string[] { });
            CollectionAssert.AreEquivalent(new Dictionary<string, int> { }, result);
        }
    }
}
