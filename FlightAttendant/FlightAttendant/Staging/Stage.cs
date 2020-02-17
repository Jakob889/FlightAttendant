using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAttendant.Staging
{
    public class Stage
    {
        public object Fl = null;

        public void load()
        {
            FlightServiceReferenceEmirates.FlightServiceClient obj = new FlightServiceReferenceEmirates.FlightServiceClient();
            Fl = obj.GetFlights();
        }

        public void insert()
        {

        }

    }
}

    