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
                FindMultiples findMultiples = new FindMultiples();
                findMultiples.FindMultiple(inputNumber);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}
