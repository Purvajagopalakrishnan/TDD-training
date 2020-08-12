using System;

namespace TDD_Training
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input number");
            var inputNumber = int.Parse(Console.ReadLine());
            var fizzBuzzService = new FizzBuzzService();
            fizzBuzzService.CheckFizzBuzz(inputNumber);
        }
    }
}
