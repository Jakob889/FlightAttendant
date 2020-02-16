using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightAttendant
{
    public class AirlineData
    {
        public int FlightNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }


    }
    public class TestData
    {
        private static List<AirlineData> Data { get; set; } = new List<AirlineData>();
        //Data.add(new AirlineData {FlightNumber = 123, From = "ZH", To = "DBU"});
    } 

}

