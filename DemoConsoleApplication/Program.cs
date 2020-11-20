using System;

namespace DemoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            string input = Console.ReadLine();

            int number = int.Parse(input);

            if(number >= 100)
            {
                Console.WriteLine("That's a big number");
            }
            else
            {
                Console.WriteLine("That's a small number");
            }
        }
    }
}
