using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());
            if (mark >= 3.00) Console.WriteLine("Passed!");
            else Console.WriteLine("Failed!");
        }
    }
}
