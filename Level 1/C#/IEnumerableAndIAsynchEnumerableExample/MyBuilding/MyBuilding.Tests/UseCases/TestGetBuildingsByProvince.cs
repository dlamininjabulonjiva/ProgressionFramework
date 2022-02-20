using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using MyBuilding.TestInfrastructure.Builders;
using MyBuilding.UseCases;
using NSubstitute;
using NUnit.Framework;

namespace MyBuilding.Tests.UseCases
{
  [TestFixture]
  public class TestGetBuildingsByProvince
  {
    [TestFixture]
    public class Execute
    {
      [Test]
      public void GivenRequestNull_ShouldThrow()
      {
        // Arrange
        var sut = CreateSut();
        // Act
        Func<Task> action = async () => await sut.Execute(null);
        // Assert
        action.Should().Throw<ArgumentNullException>().Which.ParamName.Should().Be("request");
      }

      [Test]
      public async Task GivenNoMatchingBuildings_ShouldReturnEmpty()
      {
        // Arrange
        var request = new GetBuildingsByProvinceRequestTestDataBuilder()
          .WithProvince("Western Cape")
          .Build();

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

        var buildingAddress3 = new BuildingAddressTestDataBuilder()
          .WithPostalCode("6358")
          .WithProvince("North West")
          .WithStreetName("Dr P Johnson Road")
          .WithSuburb("North West")
          .Build();
        var building3 = new BuildingTestDataBuilder()
          .WithBuildingId(Guid.NewGuid())
          .WithBuildingName("Shank House")
          .WithBuildingDescription("This is a residence")
          .WithBuildingAddress(buildingAddress3)
          .Build();

        var allBuildings = new List<Building> { building1, building2, building3 };

        var buildingProvider = Substitute.For<IProvideBuilding>();
        buildingProvider.GetAllBuildings().Returns(allBuildings);

        var sut = CreateSut(provideBuildings: buildingProvider);
        // Act
        var actual = await sut.Execute(request);
        // Assert
        actual.Should().BeEmpty();
      }

      [Test]
      public async Task ShouldReturnBuildingsForProvince()
      {
        // Arrange
        var request = new GetBuildingsByProvinceRequestTestDataBuilder()
          .WithProvince("KZN")
          .Build();

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

        var buildingAddress3 = new BuildingAddressTestDataBuilder()
          .WithPostalCode("6358")
          .WithProvince("North West")
          .WithStreetName("Dr P Johnson Road")
          .WithSuburb("North West")
          .Build();
        var building3 = new BuildingTestDataBuilder()
          .WithBuildingId(Guid.NewGuid())
          .WithBuildingName("Shank House")
          .WithBuildingDescription("This is a residence")
          .WithBuildingAddress(buildingAddress3)
          .Build();

        var allBuildings = new List<Building>
        {
          building1, building2, building3
        };

        var expectedBuildings = new[]
        {
          building1, building2
        };

        var provideBuildings = Substitute.For<IProvideBuilding>();
        provideBuildings.GetAllBuildings().Returns(allBuildings);

        var sut = CreateSut(provideBuildings: provideBuildings);
        // Act
        var actual = await sut.Execute(request);
        // Assert
        actual.Should().BeEquivalentTo(expectedBuildings);
      }
    }

    private static GetBuildingsByProvince CreateSut(
      IProvideBuilding provideBuildings = null)
    {
      return new GetBuildingsByProvince(provideBuildings);
    }
  }
}
