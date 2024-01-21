using BookingApp.Core.Models;
using BookingApp.Core.Repositories;

namespace BookingApp.Core.UseCases
{
    public class GetAllBookingsUseCase
    {
        private readonly IBookingRepository _bookingRepository;

        public GetAllBookingsUseCase(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<IEnumerable<Booking>> ExecuteAsync()
        {
            return await _bookingRepository.GetAllAsync();
        }
    }
}
