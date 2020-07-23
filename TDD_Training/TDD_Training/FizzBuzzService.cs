using System;

namespace TDD_Training
{
    public class FizzBuzzService
    {
        public string isMultipleOf(int givenNumber)
        {
            if (givenNumber % 3 == 0 && givenNumber % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (givenNumber % 3 == 0)
            {
                return "Fizz";
            }
            if (givenNumber % 5 == 0)
            {
                return "Buzz";
            }
            Console.WriteLine(givenNumber);
            return Convert.ToString(givenNumber);
        }
    }
}
