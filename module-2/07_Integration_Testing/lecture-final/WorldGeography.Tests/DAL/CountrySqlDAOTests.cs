using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CountrySQLDALTests : WorldDAOTests
    {
        [TestMethod]
        public void GetCountriesTest_Should_ReturnAllCountries()
        {
            // Arrange

            CountrySqlDAO country = new CountrySqlDAO(ConnectionString);

            // Act

            IList<Country> countryList =  country.GetCountries();

            // Assert
            Assert.AreEqual(1, countryList.Count);

        }

        [TestMethod]
        [DataRow("North America", 1)]
        [DataRow("Not a country", 0)]
        public void GetCountriesByContinent_Should_ReturnCorrectNumberOfCountries(string continent, int expectedCount)
        {
            // Arrange
            CountrySqlDAO country = new CountrySqlDAO(ConnectionString);

            // Act
            IList<Country> countryList = country.GetCountries(continent);

            // Assert
            Assert.AreEqual(expectedCount, countryList.Count);
        }
    }
}
