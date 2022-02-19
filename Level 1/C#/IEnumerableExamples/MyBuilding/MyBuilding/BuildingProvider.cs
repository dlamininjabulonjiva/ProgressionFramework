using System;
using System.Collections.Generic;

namespace MyBuilding
{
  public class BuildingProvider : IProvideBuilding
  {
    public IEnumerable<Building> GetAllBuildings()
    {
      var building1 = CreateBuildings(out var building2, out var building3);

      yield return building1;
      yield return building2;
      yield return building3;
    }

    private static Building CreateBuildings(out Building building2, out Building building3)
    {
      var building1 = new Building()
      {
        BuildingId = Guid.NewGuid(),
        BuildingName = "The Lab",
        BuildingDescription = "This is a residence",
        BuildingAddress = new BuildingAddress()
        {
          PostalCode = "4092",
          Province = "KZN",
          StreetName = "Sesame Street",
          Suburb = "Kloof",
        },
      };

      building2 = new Building()
      {
        BuildingId = Guid.NewGuid(),
        BuildingName = "The Groove",
        BuildingDescription = "This is a residence",
        BuildingAddress = new BuildingAddress()
        {
          PostalCode = "4001",
          Province = "KZN",
          StreetName = "West Street",
          Suburb = "Durban",
        },
      };

      building3 = new Building()
      {
        BuildingId = Guid.NewGuid(),
        BuildingName = "The Grave",
        BuildingDescription = "This is a gym",
        BuildingAddress = new BuildingAddress()
        {
          PostalCode = "4129",
          Province = "KZN",
          StreetName = "Arbour Road",
          Suburb = "Amanzimtoti",
        },
      };
      return building1;
    }
  }

  public interface IProvideBuilding
  {
    IEnumerable<Building> GetAllBuildings();
  }
}
