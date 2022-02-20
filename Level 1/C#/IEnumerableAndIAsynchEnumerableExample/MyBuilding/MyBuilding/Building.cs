using System;

namespace MyBuilding
{
  public class Building
  {
    public Guid BuildingId { get; set; }
    public string BuildingName { get; set; }
    public string BuildingDescription { get; set; }
    public BuildingAddress BuildingAddress { get; set; }
  }
}
