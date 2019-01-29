using System;
using System.Linq;

namespace Pairs_By_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int diff = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if(Math.Abs(array[i] - array[j]) == diff)
                    {
                        counter++;
                    }   
                }
            }
            Console.WriteLine(counter);
        }
    }
}
