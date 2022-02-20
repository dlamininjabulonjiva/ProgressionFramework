using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBuilding.UseCases
{
  public class GetBuildingsByProvince: IGetBuildingsByProvince
  {
    private readonly IProvideBuilding _provideBuildings;

    public GetBuildingsByProvince(
      IProvideBuilding provideBuildings)
    {
      _provideBuildings = provideBuildings;
    }

    public async Task<IEnumerable<Building>> Execute(GetBuildingsByProvinceRequest request)
    {
      if (request == null)
      {
        throw new ArgumentNullException(nameof(request));
      }

      var buildings = await _provideBuildings.GetAllBuildings();
      var filteredBuildings = buildings.Where(b => b.BuildingAddress.Province == request.Province);

      return filteredBuildings;
    }
  }

  public interface IGetBuildingsByProvince
  {
    Task<IEnumerable<Building>> Execute(GetBuildingsByProvinceRequest request);
  }

  public class GetBuildingsByProvinceRequest
  {
    public string Province { get; set; }
  }
}
