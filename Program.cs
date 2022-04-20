using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");
            string fname = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string lname = Console.ReadLine();
            Console.WriteLine($"Ah, so your name is {lname}, {fname} {lname}.");
            string color = Console.ReadLine();
            Console.WriteLine($"I don't expect you talk Mr/Ms {lname}, I expect you to die.");
        }
    }
}