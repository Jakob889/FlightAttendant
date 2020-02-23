using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAttendant.Book
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();

            bookingid.Text = Booked.MyBooking.BookingID.ToString();
            hotelname.Text = Booked.MyBooking.Hotelname;
            city.Text = Booked.MyBooking.City;
            checkin.Text = Booked.MyBooking.Checkin.ToString();
            checkout.Text = Booked.MyBooking.Checkout.ToString();
            downflight.Text = Booked.MyBooking.DownFlightNr;
            downdepart.Text = Booked.MyBooking.Downflightdepart.ToString();
            downarrive.Text = Booked.MyBooking.Downflightarrive.ToString();
            backflight.Text = Booked.MyBooking.BackFlightNr;
            backdepart.Text = Booked.MyBooking.Backflightdepart.ToString();
            backarrive.Text = Booked.MyBooking.Backflightarrive.ToString();
        }

        private void CloseButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}
