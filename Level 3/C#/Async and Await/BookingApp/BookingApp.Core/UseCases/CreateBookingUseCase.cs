using BookingApp.Core.Models;
using BookingApp.Core.Repositories;

namespace BookingApp.Core.UseCases
{
    public class CreateBookingUseCase
    {
        private readonly IBookingRepository _bookingRepository;

        public CreateBookingUseCase(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<int> ExecuteAsync(Booking booking)
        {
            return await _bookingRepository.AddAsync(booking);
        }
    }
}
