using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int counter = 1;
            int maxCounter = 1;
            int maxNumber = input[0];
            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i+1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxNumber = input[i];
                    }
                }
                else
                {
                    counter = 1;
                }
               
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{maxNumber} ");
            }
            Console.WriteLine();
        }
    }
}
