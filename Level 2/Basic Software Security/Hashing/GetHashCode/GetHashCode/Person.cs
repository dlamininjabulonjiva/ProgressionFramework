namespace GetHashCode
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public override bool Equals(object? objectToCompareWith)
        {
            if (objectToCompareWith == null || GetType() != objectToCompareWith.GetType())
            {
                return false;
            }

            var otherPerson = (Person)objectToCompareWith;

            return Name == otherPerson.Name && Age == otherPerson.Age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
    }
}