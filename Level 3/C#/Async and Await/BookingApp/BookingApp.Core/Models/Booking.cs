using System;

namespace BookingApp.Core.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
