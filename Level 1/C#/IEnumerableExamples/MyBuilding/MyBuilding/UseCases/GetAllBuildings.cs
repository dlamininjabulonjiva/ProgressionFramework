using System.Collections.Generic;

namespace MyBuilding.UseCases
{
  public class GetAllBuildings : IGetAllBuildings
  {
    private readonly IProvideBuilding _buildingProvider;

    public GetAllBuildings(IProvideBuilding buildingProvider)
    {
      _buildingProvider = buildingProvider;
    }

    public IEnumerable<Building> Execute()
    {
      var buildings = _buildingProvider.GetAllBuildings();
      return buildings;
    }
  }

  public interface IGetAllBuildings
  {
    IEnumerable<Building> Execute();
  }
}
