using BookingApp.Core.Models;
using BookingApp.Core.Repositories;

namespace BookingApp.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly List<Booking> _bookings;

        public BookingRepository()
        {
            _bookings = new List<Booking>
            {
                new Booking { Id = 1, CustomerName = "John Cena", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2) },
                new Booking { Id = 2, CustomerName = "Jade Hira", StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(3) },
                new Booking { Id = 3, CustomerName = "Bradley Wanrner", StartTime = DateTime.Now.AddDays(2), EndTime = DateTime.Now.AddDays(5).AddHours(3) },
                new Booking { Id = 4, CustomerName = "Taylor Swift", StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(10).AddHours(3) }
            };
        }

        public Task<Booking?> GetByIdAsync(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            return Task.FromResult(booking);
        }

        public Task<IEnumerable<Booking>> GetAllAsync()
        {
            var bookings = _bookings.ToList();
            return Task.FromResult<IEnumerable<Booking>>(bookings);
        }

        public Task<int> AddAsync(Booking booking)
        {
            booking.Id = _bookings.Count + 1;
            _bookings.Add(booking);
            return Task.FromResult(booking.Id);
        }
    }
}
