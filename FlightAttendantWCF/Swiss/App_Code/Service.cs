using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{

    private IList<Flight> flights = new List<Flight>()
        {
            new Flight { FlightNr = "EX001", From = "DXB", To = "ZRH", Seats = 5, Depart = "2020-3-2", Arrive = "2020-3-3" },
            new Flight { FlightNr = "EX004", From = "DXB", To = "ZRH", Seats = 12, Depart = "2020-3-5", Arrive = "2020-3-5" },
            new Flight { FlightNr = "EX005", From = "ZRH", To = "DXB", Seats = 0, Depart = "2020-3-6", Arrive = "2020-3-7" },
            new Flight { FlightNr = "EX006", From = "DXB", To = "ZRH", Seats = 12, Depart = "2020-3-9", Arrive = "2020-3-10" },
            new Flight { FlightNr = "EX007", From = "ZRH", To = "DXB", Seats = 21, Depart = "2020-3-12", Arrive = "2020-3-13" },
            new Flight { FlightNr = "EX008", From = "DXB", To = "ZRH", Seats = 15, Depart = "2020-3-14", Arrive = "2020-3-15" },
            new Flight { FlightNr = "EX009", From = "ZRH", To = "DXB", Seats = 4, Depart = "2020-3-16", Arrive = "2020-3-17" },
            new Flight { FlightNr = "EX011", From = "DXB", To = "ZRH", Seats = 42, Depart = "2020-3-21", Arrive = "2020-3-22" },
            new Flight { FlightNr = "EX014", From = "ZRH", To = "DXB", Seats = 3, Depart = "2020-3-28", Arrive = "2020-3-29" },

            new Flight { FlightNr = "EX021", From = "ZRH", To = "LHR", Seats = 5, Depart = "2020-3-2", Arrive = "2020-3-2" },
            new Flight { FlightNr = "EX022", From = "LHR", To = "ZRH", Seats = 2, Depart = "2020-3-3", Arrive = "2020-3-3" },
            new Flight { FlightNr = "EX024", From = "ZRH", To = "LHR", Seats = 12, Depart = "2020-3-5", Arrive = "2020-3-5" },
            new Flight { FlightNr = "EX025", From = "LHR", To = "ZRH", Seats = 0, Depart = "2020-3-6", Arrive = "2020-3-6" },
            new Flight { FlightNr = "EX026", From = "ZRH", To = "LHR", Seats = 12, Depart = "2020-3-9", Arrive = "2020-3-9" },
            new Flight { FlightNr = "EX027", From = "LHR", To = "ZRH", Seats = 21, Depart = "2020-3-12", Arrive = "2020-3-12" },
            new Flight { FlightNr = "EX028", From = "ZRH", To = "LHR", Seats = 15, Depart = "2020-3-14", Arrive = "2020-3-14" },
            new Flight { FlightNr = "EX029", From = "LHR", To = "ZRH", Seats = 4, Depart = "2020-3-16", Arrive = "2020-3-16" },
            new Flight { FlightNr = "EX030", From = "LHR", To = "ZRH", Seats = 0, Depart = "2020-3-19", Arrive = "2020-3-19" },
            new Flight { FlightNr = "EX031", From = "ZRH", To = "LHR", Seats = 12, Depart = "2020-3-21", Arrive = "2020-3-21" },
            new Flight { FlightNr = "EX032", From = "LHR", To = "ZRH", Seats = 21, Depart = "2020-3-23", Arrive = "2020-3-23" },
            new Flight { FlightNr = "EX033", From = "ZRH", To = "LHR", Seats = 15, Depart = "2020-3-25", Arrive = "2020-3-25" },
            new Flight { FlightNr = "EX034", From = "LHR", To = "ZRH", Seats = 4, Depart = "2020-3-28", Arrive = "2020-3-28" },

            new Flight { FlightNr = "EX010", From = "ZRH", To = "JFK", Seats = 10, Depart = "2020-3-1", Arrive = "2020-3-2" },
            new Flight { FlightNr = "EX002", From = "JFK", To = "ZRH", Seats = 2, Depart = "2020-3-4", Arrive = "2020-3-4" },
            new Flight { FlightNr = "EX012", From = "ZRH", To = "JFK", Seats = 31, Depart = "2020-3-8", Arrive = "2020-3-9" },
            new Flight { FlightNr = "EX013", From = "JFK", To = "ZRH", Seats = 65, Depart = "2020-3-13", Arrive = "2020-3-14" },
            new Flight { FlightNr = "EX010", From = "ZRH", To = "JFK", Seats = 10, Depart = "2020-3-18", Arrive = "2020-3-19" },
            new Flight { FlightNr = "EX002", From = "JFK", To = "ZRH", Seats = 2, Depart = "2020-3-21", Arrive = "2020-3-21" },
            new Flight { FlightNr = "EX012", From = "ZRH", To = "JFK", Seats = 31, Depart = "2020-3-22", Arrive = "2020-3-22" },
            new Flight { FlightNr = "EX013", From = "JFK", To = "ZRH", Seats = 65, Depart = "2020-3-28", Arrive = "2020-3-28" }

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
