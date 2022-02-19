using System;
using System.Collections.Generic;
using MyBuilding.TestInfrastructure.Builders;
using MyBuilding.UseCases;
using NSubstitute;
using NUnit.Framework;

namespace MyBuilding.Tests.UseCases
{
  [TestFixture]
  public class TestGetAllBuildings
  {
    [TestFixture]
    public class Execute
    {
      [Test]
      public void GivenNoBuildingsFound_ShouldReturnEmptyList()
      {
        // Arrange
        var expectedBuildings = new List<Building>();
        var buildingProvider = Substitute.For<IProvideBuilding>();
        buildingProvider.GetAllBuildings().Returns(expectedBuildings);
        var sut = CreateSut(buildingProvider: buildingProvider);
        // Act
        var actual = sut.Execute();
        // Assert
        Assert.AreEqual(expectedBuildings, actual);
      }

      [Test]
      public void GivenBuildingsFound_ShouldReturnAllTheBuildings()
      {
        // Arrange
        var buildingAddress1 = new BuildingAddressTestDataBuilder()
          .WithPostalCode("4126")
          .WithProvince("KZN")
          .WithStreetName("Nana Dube Road")
          .WithSuburb("Amanzimtoti")
          .Build();
        var building1 = new BuildingTestDataBuilder()
          .WithBuildingId(Guid.NewGuid())
          .WithBuildingName("Empire")
          .WithBuildingDescription("This is a residence")
          .WithBuildingAddress(buildingAddress1)
          .Build();

        var buildingAddress2 = new BuildingAddressTestDataBuilder()
          .WithPostalCode("4001")
          .WithProvince("KZN")
          .WithStreetName("Smith Street")
          .WithSuburb("Durban")
          .Build();
        var building2 = new BuildingTestDataBuilder()
          .WithBuildingId(Guid.NewGuid())
          .WithBuildingName("The Glove")
          .WithBuildingDescription("This is a residence")
          .WithBuildingAddress(buildingAddress2)
          .Build();

        var expectedBuildings = new List<Building> {building1, building2};

        var buildingProvider = Substitute.For<IProvideBuilding>();
        buildingProvider.GetAllBuildings().Returns(expectedBuildings);

        var sut = CreateSut(buildingProvider: buildingProvider);
        // Act
        var actual = sut.Execute();
        // Assert
        Assert.AreEqual(expectedBuildings, actual);
      }
    }

    private static GetAllBuildings CreateSut(
      IProvideBuilding buildingProvider = null)
    {
      return new GetAllBuildings(buildingProvider);
    }
  }
}
