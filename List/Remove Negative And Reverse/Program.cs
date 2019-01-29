using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negative_And_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> positiveList = new List<int>();
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    positiveList.Add(list[i]);
                }
            }
            if (positiveList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ",positiveList));
            }
        }
    }
}
