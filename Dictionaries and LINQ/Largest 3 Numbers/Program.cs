using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var result = numbers.OrderByDescending(x => x).Take(3);
            Console.Write(string.Join(" ", result));
            Console.WriteLine();
        }
    }
}
