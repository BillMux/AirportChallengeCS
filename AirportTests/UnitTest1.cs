using AirportClass;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //    Airport airport = new Airport();
        //}

        [Test]
        public void TestPlaneCanLand()
        {
            Airport airport = new Airport();
            string plane = "plane";
            airport.Land(plane);
            Assert.IsNotEmpty(airport.hangar);
            Assert.AreEqual(airport.hangar[0], plane);
        }
    }
}