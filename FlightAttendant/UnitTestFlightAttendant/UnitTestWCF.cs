using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestFlightAttendant;
using FlightAttendant;

namespace UnitTestFlightAttendant
{
    [TestClass]
    public class UnitTestWCF
    {
        [TestMethod]
        public void TestWCFDataLoadFlights()
        {
            var flightServiceClient = new FlightAttendant.FlightServiceReferenceEmirates.FlightServiceClient();

            var flights = flightServiceClient.GetFlights();

            Assert.IsTrue(flights == null);
        }
    }
}
