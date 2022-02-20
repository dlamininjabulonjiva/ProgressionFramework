using System.Collections.Generic;
using System.Threading.Tasks;

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

    public async Task<IEnumerable<Building>> Execute()
    {
      var buildings = await _buildingProvider.GetAllBuildings();
      return buildings;
    }
  }

  public interface IGetAllBuildings
  {
    Task<IEnumerable<Building>> Execute();
  }
}
