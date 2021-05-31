using NUnit.Framework;

namespace Travel.Test
{
  [TestFixture]
  public class TestTravelFactory
  {
    [Test]
    public void ShouldCalculateTheDriveForAPlane()
    {
      // Arrange
      const int kilometer = 1200;
      const int kilometerCost = 20;
      const int expected = 12000;

      var sut = CreateSut();
      // Act
      var actual = sut.CalculateDrive(kilometer, new Plane(kilometerCost));
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldCalculateTheDriveForABus()
    {
      // Arrange
      const int kilometer = 1200;
      const int kilometerCost = 20;
      const int expected = 20400;

      var sut = CreateSut();
      // Act
      var actual = sut.CalculateDrive(kilometer, new Bus(kilometerCost));
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldCalculateTheDriveForATaxi()
    {
      // Arrange
      const int kilometer = 1200;
      const int kilometerCost = 20;
      const int expected = 24000;

      var sut = CreateSut();
      // Act
      var actual = sut.CalculateDrive(kilometer, new Taxi(kilometerCost));
      // Assert
      Assert.AreEqual(expected, actual);
    }

    private static TravelFactory CreateSut()
    {
      var sut = new TravelFactory();
      return sut;
    }
  }
}
