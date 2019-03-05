﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LiveMapApp2.Models
{
    public class Room
    {
        public string RoomName { get; set; }
        public int TypeID { get; set; }
       
        public Room()
        {

        }

        public Room( string name, int typeID)
        {
            RoomName = name;
            TypeID = typeID;
        }
    }
}
