using System;
using System.Linq;

namespace Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] FirstRow = new int[2 * k];
            int[] SecondRow = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                FirstRow[i] = array[k - i - 1];
                FirstRow[FirstRow.Length - 1 - i] = array[array.Length - k + i];
                SecondRow[2 * i] = array[2 * i + k];
                SecondRow[2 * i + 1] = array[2 * i + k + 1];
            }
            int[] result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = FirstRow[i] + SecondRow[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
