using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the Number:
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            Console.WriteLine("What is the magic number?");
            int guess = -1;

            //Take the user guess value:

            while(guess != number)
            {
                Console.WriteLine("What is your guess?");
                guess = Console.Readline();


                //Evaluate if the guess is correct:

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
        }
    }
}