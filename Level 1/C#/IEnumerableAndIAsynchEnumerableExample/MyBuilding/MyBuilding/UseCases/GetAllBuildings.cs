using System.Collections.Generic;

namespace MyBuilding.UseCases
{
  public class GetAllBuildings : IGetAllBuildings
  {
    private readonly IProvideBuilding _buildingProvider;

    public GetAllBuildings(
      IProvideBuilding provideBuildings)
    {
      _buildingProvider = provideBuildings;
    }

    public async IAsyncEnumerable<Building> Execute()
    {
      foreach (var building in await _buildingProvider.GetAllBuildings())
      {
        yield return building;
      }
    }
  }

  public interface IGetAllBuildings
  {
    IAsyncEnumerable<Building> Execute();
  }
}
