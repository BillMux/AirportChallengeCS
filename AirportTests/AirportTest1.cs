using AirportClass;
using NUnit.Framework;

namespace AirportTests
{
    public class Tests
    {
        Airport testAirport;
        string plane;

        [SetUp]
        public void TestInit()
        {
            testAirport = new Airport();
            plane = "plane";
            testAirport.Land(plane);
        }

        [Test]
        public void TestPlaneCanLand()
        {
            Assert.IsNotEmpty(testAirport.hangar);
            Assert.AreEqual(testAirport.hangar[0], plane);
        }

        [Test]
        public void TestPlaneCanTakeOff()
        {
            testAirport.TakeOff(plane);
            Assert.IsEmpty(testAirport.hangar);
        }
    }
}