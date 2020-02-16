using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Emirates
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class FlightService : IFlightService
    {
        private IList<Flight> flights = new List<Flight>() 
        { 
            new Flight { FlightNr = "EM1", From = "DUB", To = "ZRH", Seats = 5 }, 
            new Flight { FlightNr = "EM2", From = "ZRH", To = "DUB", Seats = 2 },
        };

        public IList<Flight> GetFlights()
        {

            if (flights == null)
            {
                NoFlightsException m = new NoFlightsException();
                m.Reason = "no flights found";
                throw new FaultException<NoFlightsException>(m);
            }
            else
            {
                return flights;
            }

        }
    }
}
