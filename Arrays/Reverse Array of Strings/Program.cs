using System;

namespace Reverse_Symbols_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Symbols = Console.ReadLine().Split(' ');
            for (int i = 0; i < Symbols.Length/2; i++)
            {
                string changer = Symbols[i];
                Symbols[i] = Symbols[Symbols.Length - i - 1];
                Symbols[Symbols.Length - i - 1] = changer;
            }
            Console.WriteLine(string.Join(" ", Symbols));

        }
    }
}
