using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahhh You seek the grail? ");
            Console.WriteLine("You must answer my riddles three! ");
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your quest? ");
            string quest = Console.ReadLine();
            Console.WriteLine("What is your Favorite Color? ");
            string color = Console.ReadLine();
            Console.WriteLine("You may go.");
        }
    }
}