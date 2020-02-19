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
            new Flight { FlightNr = "EM001", From = "DXB", To = "ZRH", Seats = 5, Depart = "2020-3-2", Arrive = "2020-3-3" }, 
            new Flight { FlightNr = "EM002", From = "ZRH", To = "DXB", Seats = 2, Depart = "2020-3-3", Arrive = "2020-3-4" },
            new Flight { FlightNr = "EM004", From = "DXB", To = "ZRH", Seats = 12, Depart = "2020-3-5", Arrive = "2020-3-5" },
            new Flight { FlightNr = "EM005", From = "ZRH", To = "DXB", Seats = 0, Depart = "2020-3-6", Arrive = "2020-3-7" },
            new Flight { FlightNr = "EM006", From = "DXB", To = "ZRH", Seats = 12, Depart = "2020-3-9", Arrive = "2020-3-10" },
            new Flight { FlightNr = "EM007", From = "ZRH", To = "DXB", Seats = 21, Depart = "2020-3-12", Arrive = "2020-3-13" },
            new Flight { FlightNr = "EM008", From = "DXB", To = "ZRH", Seats = 15, Depart = "2020-3-14", Arrive = "2020-3-15" },
            new Flight { FlightNr = "EM009", From = "ZRH", To = "DXB", Seats = 4, Depart = "2020-3-16", Arrive = "2020-3-17" },
            new Flight { FlightNr = "EM010", From = "ZRH", To = "DXB", Seats = 10, Depart = "2020-3-19", Arrive = "2020-3-20" },
            new Flight { FlightNr = "EM011", From = "DXB", To = "ZRH", Seats = 42, Depart = "2020-3-21", Arrive = "2020-3-22" },
            new Flight { FlightNr = "EM012", From = "ZRH", To = "DXB", Seats = 31, Depart = "2020-3-23", Arrive = "2020-3-24" },
            new Flight { FlightNr = "EM013", From = "DXB", To = "ZRH", Seats = 65, Depart = "2020-3-25", Arrive = "2020-3-27" },
            new Flight { FlightNr = "EM014", From = "ZRH", To = "DXB", Seats = 3, Depart = "2020-3-28", Arrive = "2020-3-29" },

            new Flight { FlightNr = "EM021", From = "ZRH", To = "SIN", Seats = 5, Depart = "2020-3-2", Arrive = "2020-3-3" },
            new Flight { FlightNr = "EM022", From = "SIN", To = "ZRH", Seats = 2, Depart = "2020-3-3", Arrive = "2020-3-4" },
            new Flight { FlightNr = "EM024", From = "ZRH", To = "SIN", Seats = 12, Depart = "2020-3-5", Arrive = "2020-3-5" },
            new Flight { FlightNr = "EM025", From = "SIN", To = "ZRH", Seats = 0, Depart = "2020-3-6", Arrive = "2020-3-7" },
            new Flight { FlightNr = "EM026", From = "ZRH", To = "SIN", Seats = 12, Depart = "2020-3-9", Arrive = "2020-3-10" },
            new Flight { FlightNr = "EM027", From = "SIN", To = "ZRH", Seats = 21, Depart = "2020-3-12", Arrive = "2020-3-13" },
            new Flight { FlightNr = "EM028", From = "ZRH", To = "SIN", Seats = 15, Depart = "2020-3-14", Arrive = "2020-3-15" },
            new Flight { FlightNr = "EM029", From = "SIN", To = "ZRH", Seats = 4, Depart = "2020-3-16", Arrive = "2020-3-17" },
            new Flight { FlightNr = "EM030", From = "SIN", To = "ZRH", Seats = 0, Depart = "2020-3-19", Arrive = "2020-3-20" },
            new Flight { FlightNr = "EM031", From = "ZRH", To = "SIN", Seats = 12, Depart = "2020-3-21", Arrive = "2020-3-22" },
            new Flight { FlightNr = "EM032", From = "SIN", To = "ZRH", Seats = 21, Depart = "2020-3-23", Arrive = "2020-3-24" },
            new Flight { FlightNr = "EM033", From = "ZRH", To = "SIN", Seats = 15, Depart = "2020-3-25", Arrive = "2020-3-27" },
            new Flight { FlightNr = "EM034", From = "SIN", To = "ZRH", Seats = 4, Depart = "2020-3-28", Arrive = "2020-3-29" }
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
