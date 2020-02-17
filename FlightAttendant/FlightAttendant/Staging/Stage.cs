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
            LoadFlights();
        }

        private static void LoadFlights()
        {
            var flightServiceClient = new FlightServiceReferenceEmirates.FlightServiceClient();
            var flights = flightServiceClient.GetFlights();
            foreach (var item in flights)
            {
                using (var ctx = new FlightAttendantEntities())
                {
                    if (!ctx.Flights.Any(x => x.FlightNr == item.FlightNr))
                    {
                        var flightinsert = new Flights() { FlightNr = item.FlightNr, From = item.From, To = item.To, Seats = item.Seats };
                        ctx.Flights.Add(flightinsert);
                        ctx.SaveChanges();
                    }
                }
            }
        }
    }
}

    