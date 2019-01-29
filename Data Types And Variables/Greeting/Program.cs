using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {FirstName} {LastName}. You are {age} years old.");
        }
    }
}
