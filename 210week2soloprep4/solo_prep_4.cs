using System.Collections.Generic;

namespace solo_prep_4.cs
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.WriteLine("Enter Number: "); numbers.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine($"The Sum is: {numbers.Sum()}");
            Console.WriteLine($"The average is: {numbers.Average()}");
            Console.WriteLine($"The largest number is: {numbers.Max()}");
        }
    }
}