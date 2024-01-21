using NUnit.Framework;
using NSubstitute;
using BookingApp.Core.Repositories;
using BookingApp.Core.Models;
using BookingApp.Core.UseCases;

namespace BookingApp.Core.Test.UseCases
{
    [TestFixture]
    public class GetBookingByIdUseCaseTests
    {
        [Test]
        public async Task ExecuteAsync_ReturnsNullWhenNotFound()
        {
            // Arrange
            var bookingRepository = Substitute.For<IBookingRepository>();
            bookingRepository.GetByIdAsync(1).Returns((Booking?)null);

            var sut = CreateSut(bookingRepository);
            // Act
            var result = await sut.ExecuteAsync(1);
            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task ExecuteAsync_ReturnsBookingWhenFound()
        {
            // Arrange
            var expectedBooking = new Booking
            {
                Id = 1,
                CustomerName = "John Cena",
                StartTime = DateTime.Now,
                EndTime =
                DateTime.Now.AddHours(2),
            };
            var bookingRepository = Substitute.For<IBookingRepository>();
            bookingRepository.GetByIdAsync(1).Returns(expectedBooking);

            var sut = CreateSut(bookingRepository);
            // Act
            var actualBookings = await sut.ExecuteAsync(1);
            // Assert
            Assert.That(actualBookings, Is.Not.Null);
            Assert.That(actualBookings, Is.EqualTo(expectedBooking));
        }

        private GetBookingByIdUseCase CreateSut(IBookingRepository bookingRepository)
        {
            return new GetBookingByIdUseCase(bookingRepository);
        }
    }
}
