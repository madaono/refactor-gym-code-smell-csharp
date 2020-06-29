using System;
using code_smell_recognise._09.model;

namespace code_smell_recognise._09
{
    public class RoomChecker
    {
        public bool IsRoomBooked(Room room, DateTime date) {
            return room.BookingStatus[date];
        }
    }
}