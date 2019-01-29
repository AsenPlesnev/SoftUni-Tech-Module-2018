using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Symbols = Console.ReadLine().Split(' ').Select(int.Parse).ToSymbols();
            int counter = 0;
            for (int i = 0; i < Symbols.Length; i++)
            {
                for (int j = i + 1; j < Symbols.Length; j++)
                {
                    int sum = Symbols[i] + Symbols[j];
                    if (Symbols.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", Symbols[i], Symbols[j], sum);
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}