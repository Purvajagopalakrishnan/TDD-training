using System;

namespace TDD_Training
{
    public class FizzBuzzService
    {
        public string CheckFizzBuzz(int givenNumber)
        {
            if (givenNumber <= 0)
            {
                throw new ArgumentOutOfRangeException(Convert.ToString(givenNumber), "Input Number should be positive");
            }
                
            switch (givenNumber)
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

                case int x when IsMultipleOfThirteen(givenNumber) == true:
                {
                    return "Jazz";
                }

                case int x when IsMultipleOfTwentyThree(givenNumber) == true:
                {
                    return "Wiz";
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

        public bool IsMultipleOfThirteen(int givenNumber)
        {
            return givenNumber % 13 == 0;
        }

        public bool IsMultipleOfTwentyThree(int givenNumber)
        {
            return givenNumber % 23 == 0;
        }
    }
}

