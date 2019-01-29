using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int MaxCounter = 0;
            int MaxNumber = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }

                }
                if (counter > MaxCounter)
                {
                    MaxCounter = counter;
                    MaxNumber = array[i];
                }
            }
            Console.WriteLine(MaxNumber);
        }
    }
}
