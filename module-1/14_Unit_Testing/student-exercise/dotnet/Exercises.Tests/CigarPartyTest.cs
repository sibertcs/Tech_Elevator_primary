using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void CigarPartyTests()
        {
            CigarParty cigarParty = new CigarParty();
            bool result = cigarParty.HaveParty(25, true);
            Assert.AreEqual(false, result);

            result = cigarParty.HaveParty(25, false);
            Assert.AreEqual(false, result);

            result = cigarParty.HaveParty(40, false);
            Assert.AreEqual(true, result);

            result = cigarParty.HaveParty(40, true);
            Assert.AreEqual(true, result);

            result = cigarParty.HaveParty(70, false);
            Assert.AreEqual(false, result);

            result = cigarParty.HaveParty(70, true);
            Assert.AreEqual(true, result);

            result = cigarParty.HaveParty(1900, true);
            Assert.AreEqual(true, result);
        }
}}
