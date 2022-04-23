using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            Console.WriteLine("Number is: " + number);

            
        }
    }
}