using System;

namespace DemoConsoleApplication
{
    class Program
    {

        static string[] words = { "gfwer", "wgvfre" };

        static void Method()
        {
                string[] words = new string[2];
                words[0] = "bum";
                words[1] = "frew";

        }

        static void DisplayWords()
        {
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        static void Main(string[] args)
        {
            DisplayWords();

            Method();

            Console.WriteLine("Some change");

            DisplayWords();
        }
    }
}
