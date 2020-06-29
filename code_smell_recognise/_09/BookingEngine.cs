using System;
using System.Collections.Generic;
using System.Linq;
using code_smell_recognise._09.model;

namespace code_smell_recognise._09
{
    public class BookingEngine
    {
        private List<Hotel> hotels;

        public bool HasRoom(DateTime date, int days, int roomType) {
            return FindRooms(date, days, roomType).Any();
        }

        public Reservation BookRoom(string customerName, string email, DateTime from, int bookingDays, int roomType) {
            var rooms = FindRooms(from, bookingDays, roomType);
            if (rooms.Any()) {
                return new Reservation(Guid.NewGuid().ToString(), customerName, email, from, bookingDays, rooms.First());
            }

            return null;
        }

        private List<Room> FindRooms(DateTime date, int days, int roomType) {
            return hotels
                .SelectMany(hotel => hotel.Rooms)
                .Where(room => room.RoomType.Type == roomType)
                .Where(room => Enumerable.Range(0, days).All(day => !new RoomChecker().IsRoomBooked(room, date.AddDays(day - 1))))
                .ToList();
        }
    }
}