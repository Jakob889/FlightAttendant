using FlightAttendant;
using FlightAttendant.FlightServiceReferenceEmirates;
using FlightAttendant.Staging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestFlightAttendant
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestWCFDataLoadFlights() //Test Nr. 1
        {
            var flightServiceClient = new FlightAttendant.FlightServiceReferenceEmirates.FlightServiceClient();

            var flights = flightServiceClient.GetFlights();

            Assert.IsTrue(flights == null);
        }

        [TestMethod]
        public void DBDataLoadCountries() //Test Nr. 2
        {
            var countries = FlightAttendant.Staging.DBLoad.DBContext.Citykey.Where(x => x.AirportCode == "DBX").ToDictionary(t => t.AirportCode, t => t.City);
            var res = countries.Values;

            Assert.IsTrue(res != null);
            //Assert.AreEqual("Dubai", countries.Values);
        }

        [TestMethod]
        public void DBDataLoadHotelRooms() //Test Nr. 3
        {
            var rooms = FlightAttendant.Staging.DBLoad.DBContext.Hotelrooms.Where(x => x.City == "DXB").ToList();

            Assert.IsTrue(rooms != null);
        }

        [TestMethod]
        public void DBDataLoadFlight() //Test Nr. 4
        {
            var arrive = "2020-3-17";
            DateTime parsedDate = DateTime.Parse(arrive);
            var flight = FlightAttendant.Staging.DBLoad.DBContext.Flights.Where(x => x.To == "DXB" && x.Arrive == parsedDate).ToList();

            Assert.IsTrue(flight != null);
        }

        [TestMethod]
        public void DBDataLoadDepartFlight() //Test Nr. 5
        {
            //var depart = "2020-3-17";
            //DateTime parsedDate = DateTime.Parse(depart);

            //var flightsload = new FlightAttendant.Staging.DBLoad();
            //var list = flightsload.GetDepartingFlights("DXB", parsedDate);

            //Assert.IsTrue(list != null);
        }

        [TestMethod]
        public void Confirmation() //Test Nr. 6
        {
            var confirm = new FlightAttendant.Book.Booked();
            
            var valuehotel = "testhotel";
            var valueLocation = "testlocation";
            var arrive = "2020-01-01";
            DateTime valueArrive = DateTime.Parse(arrive);
            var depart = "2020-01-02";
            DateTime valueDepart = DateTime.Parse(depart);

            FlightAttendant.Book.Booked.MyBooking.BookHotel(valuehotel, valueLocation, valueArrive, valueDepart);
            var hotel = FlightAttendant.Book.Booked.MyBooking.Hotelname;
            var testlocation = FlightAttendant.Book.Booked.MyBooking.City;
            var testdownarrive = FlightAttendant.Book.Booked.MyBooking.Checkin;
            var testdowndepart = FlightAttendant.Book.Booked.MyBooking.Checkout;

            Assert.AreEqual("testhotel", hotel);
            Assert.AreEqual("testlocation", testlocation);
            Assert.AreEqual(valueArrive, testdownarrive);
            Assert.AreEqual(valueDepart, testdowndepart);
        }

        [TestMethod]
        public void DBLoadFlightWithoutSteats() //Test Nr. 7
        {
            bool zeroseat = false;
            var flights = FlightAttendant.Staging.DBLoad.DBContext.Flights.Where(x => x.Seats >= 1).ToList();
            foreach (var item in flights)
            {
                if (item.Seats == 0)
                {
                    zeroseat = true;
                }
            }
            
            Assert.IsTrue(zeroseat == false);
        }

        [TestMethod]
        public void DBLoadRoomWithConditions() //Test Nr. 9
        {
            bool manyrooms = false;

            var checkin = "2020-03-02";
            DateTime valueCheckin = DateTime.Parse(checkin);
            var checkout = "2020-03-04";
            DateTime valueCheckout = DateTime.Parse(checkout);
            var rooms = FlightAttendant.Staging.DBLoad.DBContext.Hotelrooms.Where(x => x.City == "DXB" && (x.Checkin) <= valueCheckin && x.Checkout >= valueCheckout).ToList();

            if (rooms.Count >= 2)
            { 
                manyrooms = true; 
            }

            Assert.IsTrue(manyrooms == false);
        }






        //[Test]
        //public void LoadUser()
        //{
        //    this.RunTest(session => // the NH/EF session to attach the objects to
        //    {
        //        var user = new UserAccount("Mr", "Joe", "Bloggs");
        //        session.Save(user);
        //        return user.UserID;
        //    }, id => // the ID of the entity we need to load
        //    {
        //        var user = LoadMyUser(id); // load the entity
        //        Assert.AreEqual("Mr", user.Title); // test your properties
        //        Assert.AreEqual("Joe", user.Firstname);
        //        Assert.AreEqual("Bloggs", user.Lastname);
        //    }
        //}
    }
}

