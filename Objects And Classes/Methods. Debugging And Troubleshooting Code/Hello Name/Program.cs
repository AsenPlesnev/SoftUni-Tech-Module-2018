using System;

namespace Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        private static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
