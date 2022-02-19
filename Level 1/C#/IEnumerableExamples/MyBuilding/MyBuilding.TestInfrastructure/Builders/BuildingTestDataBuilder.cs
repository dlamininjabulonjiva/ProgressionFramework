using System;

namespace MyBuilding.TestInfrastructure.Builders
{
  public class BuildingTestDataBuilder
  {
    private readonly Building _building;

    public BuildingTestDataBuilder()
    {
      _building = new Building();
    }

    public BuildingTestDataBuilder WithBuildingId(Guid buildingId)
    {
      _building.BuildingId = buildingId;
      return this;
    }

    public BuildingTestDataBuilder WithBuildingName(string buildingName)
    {
      _building.BuildingName = buildingName;
      return this;
    }

    public BuildingTestDataBuilder WithBuildingDescription(string buildingDescription)
    {
      _building.BuildingDescription = buildingDescription;
      return this;
    }

    public BuildingTestDataBuilder WithBuildingAddress(BuildingAddress buildingAddress)
    {
      _building.BuildingAddress = buildingAddress;
      return this;
    }

    public Building Build()
    {
      return _building;
    }
  }
}
