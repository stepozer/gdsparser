using System.Collections.Generic;
using InfrastuctureLayer.Gds.Sirena;
using InfrastuctureLayer.Models;
using Xunit;

namespace InfstructureLayerTests
{
    public class DriverTest
    {
        protected readonly Driver _driver;
        
        public DriverTest()
        {
            _driver = new Driver();
        }
        
        [Fact]
        public void TestTrips()
        {
            var trips = _driver.Trips();

            Assert.Equal(4, trips.Count);
            Assert.Equal("SU", trips[0].Supplier);
            Assert.Equal("S7", trips[1].Supplier);
            Assert.Equal("N4", trips[2].Supplier);
            Assert.Equal("XX", trips[3].Supplier);
            Assert.Equal("10", trips[0].Fligth);
            Assert.Equal("11", trips[1].Fligth);
            Assert.Equal("15", trips[2].Fligth);
            Assert.Equal("20", trips[3].Fligth);
        }
    }
}