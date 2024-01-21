using BookingApp.Core.Models;
using BookingApp.Core.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.Api.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingController : ControllerBase
    {
        private readonly GetAllBookingsUseCase _getAllBookingsUseCase;
        private readonly CreateBookingUseCase _createBookingUseCase;
        private readonly GetBookingByIdUseCase _getBookingByIdUseCase;

        public BookingController(
            GetAllBookingsUseCase getAllBookingsUseCase, 
            CreateBookingUseCase createBookingUseCase,
            GetBookingByIdUseCase getBookingByIdUseCase)
        {
            _getAllBookingsUseCase = getAllBookingsUseCase;
            _createBookingUseCase = createBookingUseCase;
            _getBookingByIdUseCase = getBookingByIdUseCase;
        }

        [HttpGet]
        public async Task<IEnumerable<Booking>> GetAllAsync()
        {
            return await _getAllBookingsUseCase.ExecuteAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetByIdAsync(int id)
        {
            var booking = await _getBookingByIdUseCase.ExecuteAsync(id);

            if (booking == null)
            {
                return NotFound();
            }

            return booking;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateAsync([FromBody] Booking booking)
        {
            var id = await _createBookingUseCase.ExecuteAsync(booking);
            return Ok(id);
        }
    }
}
