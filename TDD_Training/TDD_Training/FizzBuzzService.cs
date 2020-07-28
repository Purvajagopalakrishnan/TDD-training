using System;

namespace TDD_Training
{
    public class FizzBuzzService
    {
        public string CheckFizzBuzz(int givenNumber)
        {
            switch(givenNumber)
            {
                case int _ when IsMultipleOfThreeAndFive(givenNumber) == true:
                {
                    return "FizzBuzz";
                }

                case int x when IsMultipleOfThree(givenNumber) == true:
                {
                    return "Fizz";
                }

                case int x when IsMultipleOfFive(givenNumber) == true:
                {
                    return "Buzz";
                }
                default:
                {
                    return Convert.ToString(givenNumber);
                }
            }
        }

        public bool IsMultipleOfThree(int givenNumber)
        {
            return givenNumber % 3 == 0;
        }

        public bool IsMultipleOfFive(int givenNumber)
        {
            return givenNumber % 5 == 0;
        }

        public bool IsMultipleOfThreeAndFive(int givenNumber)
        {
            return (IsMultipleOfThree(givenNumber) && IsMultipleOfFive(givenNumber));
        }
    }
}

