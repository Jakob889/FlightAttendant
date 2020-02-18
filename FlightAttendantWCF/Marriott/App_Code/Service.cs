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
    private IList<Room> rooms = new List<Room>()
    {
            new Room { City = "DUB", RoomNr = 004, Checkin = "2020-3-2",  Checkout = "2020-3-4"},
            new Room { City = "DUB", RoomNr = 009, Checkin = "2020-3-6",  Checkout = "2020-3-15"},
            new Room { City = "DUB", RoomNr = 106, Checkin = "2020-3-9",  Checkout = "2020-3-14"},
            new Room { City = "DUB", RoomNr = 108, Checkin = "2020-3-17", Checkout = "2020-3-21"},
            new Room { City = "DUB", RoomNr = 105, Checkin = "2020-3-22", Checkout = "2020-3-28"},
            new Room { City = "DUB", RoomNr = 505, Checkin = "2020-3-23", Checkout = "2020-3-26"},
            new Room { City = "DUB", RoomNr = 506, Checkin = "2020-3-25", Checkout = "2020-3-28"},
            new Room { City = "DUB", RoomNr = 510, Checkin = "2020-3-16", Checkout = "2020-3-20"},
            new Room { City = "DUB", RoomNr = 604, Checkin = "2020-3-18", Checkout = "2020-3-19"},

            new Room { City = "SIN", RoomNr = 006, Checkin = "2020-3-2",  Checkout = "2020-3-4"},
            new Room { City = "SIN", RoomNr = 019, Checkin = "2020-3-6",  Checkout = "2020-3-15"},
            new Room { City = "SIN", RoomNr = 104, Checkin = "2020-3-9",  Checkout = "2020-3-14"},
            new Room { City = "SIN", RoomNr = 105, Checkin = "2020-3-17", Checkout = "2020-3-21"},
            new Room { City = "SIN", RoomNr = 106, Checkin = "2020-3-22", Checkout = "2020-3-28"},
            new Room { City = "SIN", RoomNr = 405, Checkin = "2020-3-23", Checkout = "2020-3-26"},
            new Room { City = "SIN", RoomNr = 406, Checkin = "2020-3-25", Checkout = "2020-3-28"},
            new Room { City = "SIN", RoomNr = 410, Checkin = "2020-3-16", Checkout = "2020-3-20"},
            new Room { City = "SIN", RoomNr = 504, Checkin = "2020-3-18", Checkout = "2020-3-19"}

    };


    public IList<Room> GetRooms()
    {

        if (rooms == null)
        {
            NoRoomException m = new NoRoomException();
            m.Reason = "no rooms found";
            throw new FaultException<NoRoomException>(m);
        }
        else
        {
            return rooms;
        }

    }
}
