using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAttendant.Staging
{
    class ConTest
    {

        public void TestWCFConnection()
        {
            try
            {
                var flightServiceClient = new FlightServiceReferenceEmirates.FlightServiceClient();
                flightServiceClient.GetFlights();
                var MarriottServiceClient = new HotelServiceReferenceMarriott.ServiceClient();
                MarriottServiceClient.GetRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No WCF Connection: " + ex.Message, "WCF ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
