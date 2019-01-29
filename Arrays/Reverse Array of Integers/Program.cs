using System;

namespace Reverse_Symbols_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Symbols.Reverse(Numbers);
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
        }
    }
}
