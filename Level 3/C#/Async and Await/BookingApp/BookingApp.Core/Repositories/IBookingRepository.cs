using BookingApp.Core.Models;

namespace BookingApp.Core.Repositories
{
    public interface IBookingRepository
    {
        Task<Booking?> GetByIdAsync(int id);
        Task<IEnumerable<Booking>> GetAllAsync();
        Task<int> AddAsync(Booking booking);
    }
}
