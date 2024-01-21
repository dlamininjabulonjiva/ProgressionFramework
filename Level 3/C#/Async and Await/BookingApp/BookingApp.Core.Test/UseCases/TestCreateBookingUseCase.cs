using NUnit.Framework;
using NSubstitute;
using BookingApp.Core.Repositories;
using BookingApp.Core.Models;
using BookingApp.Core.UseCases;

namespace BookingApp.Core.Test.UseCases
{
    [TestFixture]
    public class TestCreateBookingUseCase
    {
        [Test]
        public async Task ExecuteAsync_ValidBooking_ReturnsBookingId()
        {
            // Arrange
            var expectedNewBooking = new Booking
            {
                Id = 1,
                CustomerName = "John Cena",
                StartTime = DateTime.Now,
                EndTime =
                DateTime.Now.AddHours(2),
            };

            var bookingRepository = Substitute.For<IBookingRepository>();
            bookingRepository.AddAsync(expectedNewBooking).Returns(expectedNewBooking.Id);

            var sut = CreateSut(bookingRepository);
            // Act
            var actual = await sut.ExecuteAsync(expectedNewBooking);
            // Assert
            Assert.That(actual, Is.EqualTo(expectedNewBooking.Id));
        }

        private CreateBookingUseCase CreateSut(IBookingRepository bookingRepository)
        {
            return new CreateBookingUseCase(bookingRepository);
        }
    }
}
