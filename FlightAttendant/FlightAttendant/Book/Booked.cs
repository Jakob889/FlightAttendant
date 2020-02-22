using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAttendant.Book
{
    public class Booked
    {
        public static Booked MyBook { get; private set; }
        private int BookingID { get; set; }
        private string Hotelname { get; set; }
        private string City { get; set; }
        private DateTime Checkin { get; set; }
        private DateTime Checkout { get; set; }
        private string DownFlightNr { get; set; }
        private DateTime Downflightdepart { get; set; }
        private DateTime Downflightarrive { get; set; }
        private string BackFlightNr { get; set; }
        private DateTime Backflightdepart { get; set; }
        private DateTime Backflightarrive { get; set; }

        public Booked()
        {
            if (MyBook == null)
            {
                MyBook = this;
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

        public void BookFlightDown(string flight,DateTime downflightdepart,DateTime downflightarrive)
        {
            DownFlightNr = flight;
            Downflightdepart = downflightdepart;
            Downflightarrive = downflightarrive;
        }

        public void BookFlightBack(string flight,DateTime backflightdepart, DateTime backflightarrive)
        {
            BackFlightNr = flight;
            Backflightdepart = backflightdepart;
            Backflightarrive = backflightarrive;
        }

    }
}
