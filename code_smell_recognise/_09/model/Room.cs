using System;
using System.Collections.Generic;
using System.IO;

namespace code_smell_recognise._09.model
{
    public class Room
    {
        public Dictionary<DateTime, bool> BookingStatus { get; set; }
        public RoomType RoomType { get; set; }
    }
}