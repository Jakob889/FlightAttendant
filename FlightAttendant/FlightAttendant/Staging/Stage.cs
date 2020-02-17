using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAttendant.Staging
{
    public class Stage
    {

        public void Load()
        {
            FlightServiceReferenceEmirates.FlightServiceClient obj = new FlightServiceReferenceEmirates.FlightServiceClient();
            var flights = obj.GetFlights();
            foreach (var item in flights)
            {
                using (var ctx = new FlightAttendantEntities())
                {
                    var flightinsert = new Flights() { FlightNr = item.FlightNr, From = item.From, To = item.To, Seats = item.Seats };
                    //ctx.Flights.Add(flightinsert);
                    //ctx.SaveChanges();
                }
            }
                                 

        }

    }
}

    