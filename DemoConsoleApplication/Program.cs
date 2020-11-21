using System;

namespace DemoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simon's High Score Game!");
            int highscore = 0;

            do
            {
                Console.WriteLine("What score would you like?");
                string inputString = Console.ReadLine();
                int score = int.Parse(inputString);

                if(score > highscore)
                {
                    Console.WriteLine("Congratulations! " + score + " is the high score");
                    highscore = score;
                }

                Console.WriteLine("Would you like to play again?");

                inputString = Console.ReadLine();

                if(inputString != "no")
                {
                    continue;
                }

                Console.WriteLine("Are you sure you want to quit?");

                inputString = Console.ReadLine();

                if(inputString == "yes")
                {
                    Console.WriteLine("Goodbye. Come back soon!");
                    break;
                }

                Console.WriteLine("Great, Let's play again then!");

            } while (true);
            Console.WriteLine("Program will now exit");

        }
    }
}
