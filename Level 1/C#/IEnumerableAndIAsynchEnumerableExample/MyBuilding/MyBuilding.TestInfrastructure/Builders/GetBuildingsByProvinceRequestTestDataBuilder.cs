using MyBuilding.UseCases;

namespace MyBuilding.TestInfrastructure.Builders
{
  public class GetBuildingsByProvinceRequestTestDataBuilder
  {
    private readonly GetBuildingsByProvinceRequest _buildingsByProvinceRequest;

    public GetBuildingsByProvinceRequestTestDataBuilder()
    {
      _buildingsByProvinceRequest = new GetBuildingsByProvinceRequest();
    }

    public GetBuildingsByProvinceRequestTestDataBuilder WithProvince(string province)
    {
      _buildingsByProvinceRequest.Province = province;
      return this;
    }

    public GetBuildingsByProvinceRequest Build()
    {
      return _buildingsByProvinceRequest;
    }
  }
}
