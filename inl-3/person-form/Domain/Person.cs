using person_form.Helpers;

namespace person_form.Domain
{
    public class Person
    {
        public Person(string firstName, string lastName, string identityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdentityNumber = identityNumber;
            Gender = CalculateGender(identityNumber);
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string IdentityNumber { get; }

        public Gender Gender { get; }

        private Gender CalculateGender(string identityNumber)
        {
            return Calculator.EvenNumber(identityNumber[8])
                ? Gender.Female 
                : Gender.Male;
        }
    }
}

