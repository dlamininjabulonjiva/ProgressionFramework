namespace MyCollege
{
  public static class MyCollegeInfo
  {
    public static string CollegeName { get; set;}
    public static string Address { get; set; }

    static MyCollegeInfo()
    {
      CollegeName = "University of Johannesburg";
      Address = "Johannesburg";
    }

    public static void CollegeInfo(string collegeName, string address)
    {
      switch (collegeName)
      {
        case "Durban University Of Technology":
          CollegeName = collegeName;
          Address = address;
          break;
        case "University Cape Town":
          CollegeName = collegeName;
          Address = address;
          break;
        case "University Pretoria":
          CollegeName = collegeName;
          Address = address;
          break;
      }
    }
  }
}