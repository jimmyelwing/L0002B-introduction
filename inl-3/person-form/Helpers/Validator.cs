using System.Collections.Generic;
using System.Linq;

namespace person_form.Helpers
{
    public static class Validator
    {
        public static bool IdentityNumberIsValid(string input)
        {
            if (input.Length != 10)
                return false;

            if (!IsANumber(input))
                return false;

            var controlNumber = GetControlNumber(input);

            return 10 - (controlNumber % 10) % 10 == 10;
        }

        private static bool IsANumber(string identityNumber)
        {
            return double.TryParse(identityNumber, out _);
        }

        private static int GetControlNumber(string input)
        {
            var numbers = input.Select(x => int.Parse(x.ToString())).ToList();

            var identityNumbers = new List<int>();

            for (var i = 0; i < numbers.Count(); i++)
            {
                int result;

                if (Calculator.EvenNumber(i))
                    result = numbers[i] * 2;
                else
                {
                    result = numbers[i] * 1;
                }

                if (result >= 10)
                    identityNumbers.AddRange(result.ToString().Select(x => int.Parse(x.ToString())));
                else
                {
                    identityNumbers.Add(result);
                }
            }

            var controlNumber = identityNumbers
                .Aggregate(0, (current, number) => current + number);
            return controlNumber;
        }

    }
}
