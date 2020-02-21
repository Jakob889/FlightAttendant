﻿using FlightAttendant.FlightServiceReferenceEmirates;
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
            return DBContext.Hotelrooms.Where(x => x.City == city && (x.Checkin) >= checkin && x.Checkout <= checkout).ToList();
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
            var test = new Dictionary<string, string>();
            test.Add("SIN", "Singapur");
            test.Add("DXB", "Dubai");
            test.Add("ZRH", "Zürich");

            DBContext.Destinations.Select(s => new { s.Key = "", s.Value = "" });

            return test;
            //        List<Flights> query =
            //from flights in DBContext.Flights
            //group flights by flights.To into destinationGroup
            //orderby destinationGroup.

            //select new { Destinaion = destinationGroup.Key };



            //                    return DBContext.Flights
            //                        .GroupBy(f => f.To)
            //                        .Select(g => new
            //                        {
            //                            To = g.FirstOrDefault()
            //        //To = g 
            //    })
            //                        .ToList();


        }

    }
}

