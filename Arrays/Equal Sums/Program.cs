using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int totalSum = 0;
            foreach (int number in array)
            {
                totalSum += number;
            }
            int leftSum = 0;
            int rightSum = totalSum;
            bool hasFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                rightSum -= currentNumber;
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasFound = true;
                    break;
                }
                leftSum += currentNumber;
            }
            if (hasFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
