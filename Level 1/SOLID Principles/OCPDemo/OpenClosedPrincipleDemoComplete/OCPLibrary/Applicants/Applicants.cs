using System;

namespace OCPLibrary.Applicants
{
    public class Applicants
    {
        public List<IApplicantModel> GetApplicants()
        {
            var applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "John", LastName = "Miller" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" }
            };

            return applicants;
        }
    }
}
