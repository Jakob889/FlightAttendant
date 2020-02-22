using FlightAttendant.FlightServiceReferenceEmirates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAttendant.Staging
{
    public class DBLoad
    {

        private static FlightAttendantEntities ctx;
        public static FlightAttendantEntities DBContext
        {
            get
            {
                if (ctx == null)
                {
                    ctx = new FlightAttendantEntities();
                }
                return ctx;
            }
        }


        public static List<Hotelrooms> GetHotelrooms(string city, DateTime checkin, DateTime checkout)
        {
            return DBContext.Hotelrooms.Where(x => x.City == city && (x.Checkin) <= checkin && x.Checkout >= checkout).ToList();
        }
        public static List<Flights> GetArrivingFlights(string destination, DateTime arrive)
        {
            //return DBContext.Flights /*.Where(x => x.FlightDate > DateTime.Now)*/.ToList();
            var query = DBContext.Flights.Where(x => x.To == destination && x.Arrive >= arrive).ToList();
            return query;
        }

        public static List<Flights> GetDepartingFlights(string location, DateTime depart)
        {
            //return DBContext.Flights /*.Where(x => x.FlightDate > DateTime.Now)*/.ToList();
            return DBContext.Flights.Where(x => x.From == location && x.Depart <= depart).ToList();
        }

        public static Dictionary<string, string> GetCountries()
        {

            return DBContext.Citykey.ToDictionary(t => t.AirportCode, t => t.City);

        }

    }
}

