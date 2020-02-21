using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestFlightAttendant;

namespace UnitTestFlightAttendant
{
    [TestClass]
    public class UnitTestWCF
    {
        [TestMethod]
        public void TestWCFDataLoadFlights()
        {
            var flightServiceClient = new FlightServiceReferenceEmirates.FlightServiceClient();

            var flights = flightServiceClient.GetFlights();

            Assert.IsTrue(flightServiceClient.CurrentConnectionCount == 0);
        }
    }
}
