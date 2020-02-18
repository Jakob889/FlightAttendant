using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace App_Code
{
    [ServiceContract]
    public interface IServiceHilton
    {

        [OperationContract]
        [FaultContract(typeof(NoRoomException))]
        IList<Room> GetRooms();


    }

    [DataContract]
    public class Room
    {
        string name = "Hilton";
        string city = null;
        int roomnr = 0;
        string checkin = null;
        string checkout = null;

        [DataMember]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [DataMember]
        public int RoomNr
        {
            get { return roomnr; }
            set { roomnr = value; }
        }

        [DataMember]
        public string Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }

        [DataMember]
        public string Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }


    }
    public class NoRoomException
    {
        public string Reason { get; set; }

    }
}

