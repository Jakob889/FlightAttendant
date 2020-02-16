﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Emirates
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFlightService
    {

        [OperationContract]
        [FaultContract(typeof(NoFlightsException))]
        IList<Flight> GetFlights();

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Flight
    {
        string flightnr = null;
        string from = null;
        string to = null;
        int seats = 0;
        //DateTime depart = null;
        //DateTime arrive = null;

        [DataMember]
        public string FlightNr
        {
            get { return flightnr; }
            set { flightnr = value; }
        }

        [DataMember]
        public string From
        {
            get { return from; }
            set { from = value; }
        }

        [DataMember]
        public string To
        {
            get { return to; }
            set { to = value; }
        }

        [DataMember]
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        //[DataMember]
        //public string Depart
        //{
        //    get { return depart; }
        //    set { depart = value; }
        //}

        //[DataMember]
        //public string Arrive
        //{
        //    get { return arrive; }
        //    set { arrive = value; }
        //}
    }
    public class NoFlightsException
    {
        public string Reason { get; set; }

    }
}