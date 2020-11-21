using System;

namespace DemoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my takeaway");
            int costInPence = 0;

            string inputString;
            int selection;

            do
            {
                do
                {
                    Console.WriteLine("What would you like to eat?");
                    Console.WriteLine("1. Burger");
                    Console.WriteLine("2. Pizza");

                    inputString = Console.ReadLine();
                    selection = int.Parse(inputString);
                } while (!(selection == 1 || selection == 2));

                if (selection == 1)
                {
                    do
                    {
                        Console.WriteLine("Quarter Pound or Half Pound?");
                        Console.WriteLine("1. 1/4 lb.");
                        Console.WriteLine("2. 1/2 lb.");
                        inputString = Console.ReadLine();
                        selection = int.Parse(inputString);
                    } while (! (selection == 1 || selection == 2)) ;
                    
                    if (selection == 1)
                    {
                        costInPence += 250;
                    }
                    else if (selection == 2)
                    {
                        costInPence += 350;
                    }

                    do
                    {
                        Console.WriteLine("Would you like cheese?");
                        Console.WriteLine("Enter y for yes or n for no");
                        inputString = Console.ReadLine();
                    } while (!(inputString == "y" || inputString == "n"));

                    if (inputString == "y")
                    {
                        costInPence += 100;
                    }
                }
                else if (selection == 2)
                {
                    do
                    {
                        Console.WriteLine("What size?");
                        Console.WriteLine("1. Medium");
                        Console.WriteLine("2. Large");
                        Console.WriteLine("3. XL");
                        inputString = Console.ReadLine();
                        selection = int.Parse(inputString);

                        if (selection == 1)
                        {
                            costInPence += 500;
                        }
                        else if (selection == 2)
                        {
                            costInPence += 700;
                        }
                        else if (selection == 3)
                        {
                            costInPence += 900;
                        }
                    } while (selection < 1 || selection > 3);
                }

                inputString = "";

                while (!(inputString == "y" || inputString == "n"))
                {

                    Console.WriteLine("Current order total is " + costInPence + " pence.");
                    Console.WriteLine("Would you like anything else?");
                    Console.WriteLine("Enter y for yes or n for no");

                    inputString = Console.ReadLine();

                };

            } while (inputString == "y");

            if(costInPence > 600)
            {
                Console.WriteLine("Have a free garlic bread!");
            }

            if(costInPence > 1000)
            {
                Console.WriteLine("Free Delivery");
            }
            else
            {
                costInPence += 200;
            }

            Console.WriteLine("Cost is " + costInPence); 
        }
    }
}
