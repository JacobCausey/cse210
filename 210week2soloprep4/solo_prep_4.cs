using System.Collections.Generic;

namespace solo_prep_4.cs
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Create list and begin torture, I mean program:
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            // There needs to be a for or do loop to add numbers:
            int number = -1;
            while (number != 0)
            {
                Console.WriteLine("Enter Number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            /*Then I'll just use some writelines to drop the needed thingies:
            Console.WriteLine($"The Sum is: {numbers.Sum()}");
            Console.WriteLine($"The average is: {numbers.Average()}");
            Console.WriteLine($"The largest number is: {numbers.Max()}");*/
        }
    }
}