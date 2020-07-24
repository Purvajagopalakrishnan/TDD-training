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
                FizzBuzzService fizzBuzzService = new FizzBuzzService();
                fizzBuzzService.CheckFizzBuzz(inputNumber);
            }
            catch(Exception)
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}
