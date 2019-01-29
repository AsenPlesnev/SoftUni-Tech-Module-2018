using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> realNumbers = new SortedDictionary<double, int>();

            foreach (var number in input)
            {
                if (!realNumbers.ContainsKey(number))
                {
                    realNumbers.Add(number, 1);
                }
                else
                {
                    realNumbers[number]++;
                }
            }

            foreach (var kvp in realNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
