using AirportClass;
using NUnit.Framework;
using System;

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
            plane = "plane1";
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

        [Test]
        public void PlaneCannotStoreInFullHangar()
        {
            string nthPlane;
            string expectedLastPlane = "plane10";
            string expectedRejectedPlane = "plane11";

            for (int i = 0; i < 10; i++)
            {
                nthPlane = "plane" + (i + 2);
                testAirport.Land(nthPlane);
            }
            Assert.IsTrue(testAirport.hangar.Contains(expectedLastPlane));
            Assert.IsFalse(testAirport.hangar.Contains(expectedRejectedPlane));
            Assert.AreEqual(testAirport.hangar.Count, 10);
        }

        [Test]
        public void CannotTakeOffIfNoPlanes()
        {
            testAirport.TakeOff("plane1");

        }
    }
};