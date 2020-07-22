using System;

namespace TDD_Training
{
    public class FindMultiples
    {
        public string FindMultiple(int givenNumber)
        {
            try
            {
                if (givenNumber % 3 == 0 && givenNumber % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    return "FizzBuzz";
                }
                if (givenNumber % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    return "Fizz";
                }
                if (givenNumber % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    return "Buzz";
                }
                Console.WriteLine(givenNumber);
                return Convert.ToString(givenNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
