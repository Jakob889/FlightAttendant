using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Timers;

namespace FlightAttendant.Staging
{
    public class Stage
    {

        public void Load()
        {
            var timer = new Timer(5000);
            timer.Elapsed += Loadtimer_Tick;
            timer.Enabled = true;
        }

        private void Loadtimer_Tick(object sender, EventArgs e)
        {
            LoadFlightsEmirates();
            LoadFlightsSwiss();
            LoadMarriottRooms();
            LoadBestWesternRooms();
        }

        private static void LoadFlightsEmirates()
        {
            var EmiratesServiceClient = new FlightServiceReferenceEmirates.FlightServiceClient();
            var flights = EmiratesServiceClient.GetFlights();
            foreach (var item in flights)
            {
                using (var ctx = new FlightAttendantEntities())
                {
                    if (!ctx.Flights.Any(x => x.FlightNr == item.FlightNr ^ item.Seats == 0))
                    {
                        var flightinsert = new Flights() { FlightNr = item.FlightNr, From = item.From, To = item.To, Seats = item.Seats, Depart = Convert.ToDateTime(item.Depart), Arrive = Convert.ToDateTime(item.Arrive) };
                        ctx.Flights.Add(flightinsert);
                        ctx.SaveChanges();
                    }
                }
            }
        }

        private static void LoadFlightsSwiss()
        {
            var SwissServiceClient = new FlightServiceReferenceSwiss.ServiceClient();
            var flights = SwissServiceClient.GetFlights();
            foreach (var item in flights)
            {
                using (var ctx = new FlightAttendantEntities())
                {
                    if (!ctx.Flights.Any(x => x.FlightNr == item.FlightNr ^ item.Seats == 0))
                    {
                        var flightinsert = new Flights() { FlightNr = item.FlightNr, From = item.From, To = item.To, Seats = item.Seats, Depart = Convert.ToDateTime(item.Depart), Arrive = Convert.ToDateTime(item.Arrive) };
                        ctx.Flights.Add(flightinsert);
                        ctx.SaveChanges();
                    }
                }
            }
        }

        private static void LoadMarriottRooms()
        {
            var MarriottServiceClient = new HotelServiceReferenceMarriott.ServiceClient();
            var rooms = MarriottServiceClient.GetRooms();
            foreach (var item in rooms)
            {
                using (var ctx = new FlightAttendantEntities())
                {
                    int hotelroomid = Convert.ToInt32($"{item.HotelID}{item.RoomNr.ToString().PadLeft(3, '0')}");
                    if (!ctx.Hotelrooms.Any(x => x.HotelroomID == hotelroomid))
                    {
                        var roominsert = new Hotelrooms() {HotelroomID = hotelroomid, Name = item.Name, City = item.City, Checkin = Convert.ToDateTime(item.Checkin), Checkout = Convert.ToDateTime(item.Checkout) };
                        ctx.Hotelrooms.Add(roominsert);
                        ctx.SaveChanges();
                    }
                }
            }
        }
        private static void LoadBestWesternRooms()
        {
            var BestWesternServiceClient = new HotelServiceReferenceBestWestern.ServiceClient();
            var rooms = BestWesternServiceClient.GetRooms();
            foreach (var item in rooms)
            {
                using (var ctx = new FlightAttendantEntities())
                {
                    int hotelroomid = Convert.ToInt32(item.HotelID.ToString() + item.RoomNr.ToString());
                    if (!ctx.Hotelrooms.Any(x => x.HotelroomID == hotelroomid))
                    {
                        var roominsert = new Hotelrooms() { HotelroomID = hotelroomid, Name = item.Name, City = item.City, Checkin = Convert.ToDateTime(item.Checkin), Checkout = Convert.ToDateTime(item.Checkout) };
                        ctx.Hotelrooms.Add(roominsert);
                        ctx.SaveChanges();
                    }
                }
            }
        }
    }
}

    