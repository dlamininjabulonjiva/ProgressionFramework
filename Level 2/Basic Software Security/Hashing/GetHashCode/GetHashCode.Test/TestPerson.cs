using NUnit.Framework;
using System.Xml.Linq;

namespace GetHashCode.Test
{
    [TestFixture]
    public class TestPerson
    {
        [Test]
        public void Equals_ShouldReturnTrueForEqualObjects()
        {
            // Arrange
            var person1 = new Person(30, "Taylor");
            var person2 = new Person(30, "Taylor");
            // Act
            var actualResults = person1.Equals(person2);
            // Assert
            Assert.IsTrue(actualResults);
        }

        [Test]
        public void Equals_ShouldReturnFalseForDifferentObjects()
        {
            // Arrange
            var person1 = new Person(30, "Taylor");
            var person2 = new Person(40, "John");
            // Act
            var actualResults = person1.Equals(person2);
            // Assert
            Assert.IsFalse(actualResults);
        }

        [Test]
        public void GetHashCode_ShouldReturnTheSameValueForEqualObjects()
        {
            // Arrange
            var person1 = new Person(30, "Taylor");
            var person2 = new Person(30, "Taylor");
            // Act
            var hashCodeForPerson1 = person1.GetHashCode();
            var hashCodeForPerson2 = person2.GetHashCode();
            // Assert
            Assert.AreEqual(hashCodeForPerson1, hashCodeForPerson2);
        }

        [Test]
        public void GetHashCode_ShouldReturnDifferentValuesForDifferentObjects()
        {
            // Arrange
            var person1 = new Person(30, "Taylor");
            var person2 = new Person(40, "John");
            // Act
            var hashCodeForPerson1 = person1.GetHashCode();
            var hashCodeForPerson2 = person2.GetHashCode();
            // Assert
            Assert.AreNotEqual(hashCodeForPerson1, hashCodeForPerson2);
        }
    }
}
