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
            new Room { City = "JFK", RoomNr = 003, Checkin = "2020-3-1",  Checkout = "2020-3-4"},
            new Room { City = "JFK", RoomNr = 007, Checkin = "2020-3-3",  Checkout = "2020-3-15"},
            new Room { City = "JFK", RoomNr = 116, Checkin = "2020-3-7",  Checkout = "2020-3-14"},
            new Room { City = "JFK", RoomNr = 108, Checkin = "2020-3-14", Checkout = "2020-3-21"},
            new Room { City = "JFK", RoomNr = 104, Checkin = "2020-3-21", Checkout = "2020-3-28"},
            new Room { City = "JFK", RoomNr = 305, Checkin = "2020-3-22", Checkout = "2020-3-26"},
            new Room { City = "JFK", RoomNr = 406, Checkin = "2020-3-24", Checkout = "2020-3-28"},
            new Room { City = "JFK", RoomNr = 510, Checkin = "2020-3-27", Checkout = "2020-3-29"},
            new Room { City = "JFK", RoomNr = 604, Checkin = "2020-3-18", Checkout = "2020-3-19"},

            new Room { City = "LCY", RoomNr = 016, Checkin = "2020-3-2",  Checkout = "2020-3-4"},
            new Room { City = "LCY", RoomNr = 029, Checkin = "2020-3-6",  Checkout = "2020-3-15"},
            new Room { City = "LCY", RoomNr = 204, Checkin = "2020-3-9",  Checkout = "2020-3-14"},
            new Room { City = "LCY", RoomNr = 205, Checkin = "2020-3-17", Checkout = "2020-3-21"},
            new Room { City = "LCY", RoomNr = 306, Checkin = "2020-3-22", Checkout = "2020-3-28"},
            new Room { City = "LCY", RoomNr = 505, Checkin = "2020-3-23", Checkout = "2020-3-26"},
            new Room { City = "LCY", RoomNr = 606, Checkin = "2020-3-25", Checkout = "2020-3-28"},
            new Room { City = "LCY", RoomNr = 610, Checkin = "2020-3-16", Checkout = "2020-3-20"},
            new Room { City = "LCY", RoomNr = 704, Checkin = "2020-3-18", Checkout = "2020-3-19"}

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