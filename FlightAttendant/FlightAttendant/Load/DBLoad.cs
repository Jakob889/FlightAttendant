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
        public static FlightAttendantEntities Context
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
        //public void Load(DbSet dBSet)
        //{
        //    using (var ctx = new FlightAttendantEntities())
        //    {
        //        var dbflights = ctx.Flights;
        //        return dbflights;
        //    }
        //}
        public static List<Flights> GetFlights()
        {
            return Context.Flights /*.Where(x => x.FlightDate > DateTime.Now)*/.ToList();
        }

       //public static List<Flights> GetDestinations()
       // {
       //    return Context.Flights.SqlQuery("Select FlightNr FROM dbo.Flights").ToList();
       // }
    }
}
