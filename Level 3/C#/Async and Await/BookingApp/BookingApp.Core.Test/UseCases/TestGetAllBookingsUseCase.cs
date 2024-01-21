using NUnit.Framework;
using NSubstitute;
using BookingApp.Core.Repositories;
using BookingApp.Core.Models;
using BookingApp.Core.UseCases;
using NUnit.Framework.Legacy;

namespace BookingApp.Core.Test.UseCases
{
    [TestFixture]
    public class TestGetAllBookingsUseCase
    {
        [Test]
        public async Task ExecuteAsync_ReturnsEmptyList_WhenNoBookings()
        {
            // Arrange
            var bookingRepository = Substitute.For<IBookingRepository>();
            bookingRepository.GetAllAsync().Returns(new List<Booking>());

            var sut = CreateSut(bookingRepository);
            // Act
            var result = await sut.ExecuteAsync();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public async Task ExecuteAsync_ReturnsAllBookings()
        {
            // Arrange
            var bookingRepository = Substitute.For<IBookingRepository>();
            var expectedBookings = new List<Booking>
            {
                new Booking { Id = 1, CustomerName = "John Cena", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2) },
                new Booking { Id = 2, CustomerName = "Jade Hira", StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(3) },
                new Booking { Id = 3, CustomerName = "Bradley Wanrner", StartTime = DateTime.Now.AddDays(2), EndTime = DateTime.Now.AddDays(5).AddHours(3) },
                new Booking { Id = 4, CustomerName = "Taylor Swift", StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(10).AddHours(3) }
            };
            bookingRepository.GetAllAsync().Returns(expectedBookings);

            var sut = CreateSut(bookingRepository);
            // Act
            var actualBookings = await sut.ExecuteAsync();
            // Assert
            CollectionAssert.AreEqual(expectedBookings, actualBookings);
        }

        private GetAllBookingsUseCase CreateSut(IBookingRepository bookingRepository)
        {
            return new GetAllBookingsUseCase(bookingRepository);
        }
    }
}
