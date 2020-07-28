using System;

namespace TDD_Training
{
    public class FizzBuzzService
    {
        public string CheckFizzBuzz(int givenNumber)
        {
            switch(givenNumber)
            {
                case int _ when IsMultipleOfThreeOrFive(givenNumber) == true:
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
            if(givenNumber % 3 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsMultipleOfFive(int givenNumber)
        {
            if(givenNumber % 5 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsMultipleOfThreeOrFive(int givenNumber)
        {

            if (IsMultipleOfThree(givenNumber) && IsMultipleOfFive(givenNumber))
            {
                return true;
            }
            return false;
        }
    }
}

