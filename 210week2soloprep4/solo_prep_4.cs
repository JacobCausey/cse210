using System.Collections.Generic;

namespace solo_prep_4.cs
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            numbers.Add(int.Parse(Console.ReadLine()));
                        
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}
