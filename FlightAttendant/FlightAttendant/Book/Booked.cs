using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAttendant.Book
{
    public class Booked
    {
        public static Booked MyBooking { get; private set; }
        public int BookingID { get; set; }
        public string Hotelname { get; set; }
        public string City { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public string DownFlightNr { get; set; }
        public DateTime Downflightdepart { get; set; }
        public DateTime Downflightarrive { get; set; }
        public string BackFlightNr { get; set; }
        public DateTime Backflightdepart { get; set; }
        public DateTime Backflightarrive { get; set; }

        public Booked()
        {
            if (MyBooking == null)
            {
                MyBooking = this;
            }
        }

        public void BookHotel(string hotel, string city, DateTime checkin, DateTime checkout)
        {
            BookingID = (new Random(DateTime.Now.Millisecond)).Next();
            Hotelname = hotel;
            City = city;
            Checkin = checkin;
            Checkout = checkout;
        }

        public void BookFlightDown(string flight, DateTime downflightdepart, DateTime downflightarrive)
        {
            DownFlightNr = flight;
            Downflightdepart = downflightdepart;
            Downflightarrive = downflightarrive;
        }

        public void BookFlightBack(string flight, DateTime backflightdepart, DateTime backflightarrive)
        {
            BackFlightNr = flight;
            Backflightdepart = backflightdepart;
            Backflightarrive = backflightarrive;
        }

    }
}
