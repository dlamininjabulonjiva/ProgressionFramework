using BookingApp.Core.Models;
using BookingApp.Core.Repositories;

namespace BookingApp.Core.UseCases
{
    public class GetBookingByIdUseCase
    {
        private readonly IBookingRepository _bookingRepository;

        public GetBookingByIdUseCase(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<Booking?> ExecuteAsync(int id)
        {
            return await _bookingRepository.GetByIdAsync(id);
        }
    }
}
