using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the Number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            Console.WriteLine("What is the magic number?");
            Console.WriteLine("What is your guess?");
            string guess;
            guess = Console.Readline();
            int guessValue = int.Parse(guess);
        }
    }
}