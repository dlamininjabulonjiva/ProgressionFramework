using NUnit.Framework;

namespace MyCollege.Test
{
  [TestFixture]
  public class TestMyCollegeInfo
  {
    [Test]
    public void ShouldReturnDurbanUniversityOfTechnologyDetails()
    {
      // Arrange
      const string collegeName = "Durban University Of Technology";
      const string address = "Durban";
      // Act
      MyCollegeInfo.CollegeInfo(collegeName, address);
      //Assert
      Assert.AreEqual(collegeName, MyCollegeInfo.CollegeName);
      Assert.AreEqual(address, MyCollegeInfo.Address);
    }
    
    [Test]
    public void ShouldReturnUniversityCapeTownDetails()
    {
      // Arrange
      const string collegeName = "University Cape Town";
      const string address = "Cape Town";
      // Act
      MyCollegeInfo.CollegeInfo(collegeName, address);
      //Assert
      Assert.AreEqual(collegeName, MyCollegeInfo.CollegeName);
      Assert.AreEqual(address, MyCollegeInfo.Address);
    } 
    
    [Test]
    public void ShouldReturnUniversityPretoriaDetails()
    {
      // Arrange
      const string collegeName = "University Pretoria";
      const string address = "Pretoria";
      // Act
      MyCollegeInfo.CollegeInfo(collegeName, address);
      //Assert
      Assert.AreEqual(collegeName, MyCollegeInfo.CollegeName);
      Assert.AreEqual(address, MyCollegeInfo.Address);
    }
  }
}
