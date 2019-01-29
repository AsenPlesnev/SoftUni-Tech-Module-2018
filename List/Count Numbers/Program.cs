using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Count_Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            numbers.Sort();
            int counter = 1;
                int current = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if(current == numbers[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{current} -> {counter}");
                    counter = 1;
                    current = numbers[i];
                }
                
            }
            Console.WriteLine($"{current} -> {counter}");
        }
    }
}