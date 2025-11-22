
using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number < 20)
                {
                    Console.WriteLine("The number is less than 20.");
                }
                else if (number == 20)
                {
                    Console.WriteLine("The number is exactly 20.");
                }
                else
                {
                    Console.WriteLine("The number is greater than 20.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
