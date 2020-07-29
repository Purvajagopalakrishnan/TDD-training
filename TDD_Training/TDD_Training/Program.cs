using System;

namespace TDD_Training
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input number");
            try
            {
                var inputNumber = int.Parse(Console.ReadLine());
                if(inputNumber <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (inputNumber > 0)
                {
                    FizzBuzzService fizzBuzzService = new FizzBuzzService();
                    fizzBuzzService.CheckFizzBuzz(inputNumber);
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Enter a valid number", ex.Message);
            }
        }
    }
}
