using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet.WebApi.Models
{
    public class Room
    {
        public static List<Room> Rooms = new List<Room>
        {
            new Room{ RoomId = 1, Area = 57.5, RoomName = "325E"},
            new Room{ RoomId = 2, Area = 27.5, RoomName = "325F"},
            new Room{ RoomId = 3, Area = 157.5, RoomName = "325G"},
        };

        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public double Area { get; set; }
    }
}