using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBuilding.UseCases
{
  public class GetBuildingsByProvince
  {
    private readonly IProvideBuilding _provideBuildings;

    public GetBuildingsByProvince(
      IProvideBuilding provideBuildings)
    {
      _provideBuildings = provideBuildings;
    }

    public async IAsyncEnumerable<Building> Execute(GetBuildingsByProvinceRequest request)
    {
      if (request == null)
      {
        throw new ArgumentNullException(nameof(request));
      }

      var buildings = await _provideBuildings.GetAllBuildings();
      var filteredBuildings = buildings.Where(b => b.BuildingAddress.Province == request.Province);

      foreach (var filteredBuilding in filteredBuildings)
      {
        yield return filteredBuilding;
      }
    }
  }

  public class GetBuildingsByProvinceRequest
  {
    public string Province { get; set; }
  }
}
