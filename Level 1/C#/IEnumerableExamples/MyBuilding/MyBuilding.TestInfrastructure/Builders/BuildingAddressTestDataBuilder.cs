using System;
using System.Collections.Generic;
using System.Text;

namespace MyBuilding.TestInfrastructure.Builders
{
  public class BuildingAddressTestDataBuilder
  {
    private readonly BuildingAddress _buildingAddress;

    public BuildingAddressTestDataBuilder()
    {
      _buildingAddress = new BuildingAddress();
    }

    public BuildingAddressTestDataBuilder WithPostalCode(string postalCode)
    {
      _buildingAddress.PostalCode = postalCode;
      return this;
    }

    public BuildingAddressTestDataBuilder WithProvince(string province)
    {
      _buildingAddress.Province = province;
      return this;
    }

    public BuildingAddressTestDataBuilder WithStreetName(string streetName)
    {
      _buildingAddress.StreetName = streetName;
      return this;
    }

    public BuildingAddressTestDataBuilder WithSuburb(string suburb)
    {
      _buildingAddress.Suburb = suburb;
      return this;
    }

    public BuildingAddress Build()
    {
      return _buildingAddress;
    }
  }
}
