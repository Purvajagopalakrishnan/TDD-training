using System;

namespace TDD_Training
{
    public class FizzBuzzService
    {
        public string CheckFizzBuzz(int givenNumber)
        {
            switch(givenNumber % 3 == 0 && givenNumber % 5 == 0 ? "FizzBuzz" : 
                givenNumber % 3 == 0 ? "Fizz" :
                givenNumber % 5 == 0 ? "Buzz" :
                Convert.ToString(givenNumber))
            {
                case "Fizz":
                {
                    return "Fizz";
                }
                case "Buzz":
                {
                        return "Buzz";
                       
                }
                case "FizzBuzz":
                {
                        return "FizzBuzz";
                }
                default:
                {
                        return Convert.ToString(givenNumber);
                }
            }
        }
    }
}
