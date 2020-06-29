using System;

namespace code_smell_recognise._09.model
{
    public class Reservation
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public DateTime From { get; set; }
        public int BookingDays { get; set; }
        public Room Room { get; set; }

        public Reservation(string id, string customerName, string email, DateTime @from, int bookingDays, Room room)
        {
            Id = id;
            CustomerName = customerName;
            Email = email;
            From = @from;
            BookingDays = bookingDays;
            Room = room;
        }
    }
}