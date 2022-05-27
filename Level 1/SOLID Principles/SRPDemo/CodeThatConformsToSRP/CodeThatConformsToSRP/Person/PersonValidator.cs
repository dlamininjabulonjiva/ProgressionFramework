using CodeThatConformsToSRP.Messaging;

namespace CodeThatConformsToSRP.Person
{
    public class PersonValidator
    {
        public bool Validate(Person person)
        {
            var standardMessages = new StandardMessages();

            // Checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                standardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                standardMessages.DisplayValidationError("last name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.IdNumber))
            {
                standardMessages.DisplayValidationError("id number");
                return false;
            }

            return true;
        }
    }
}
