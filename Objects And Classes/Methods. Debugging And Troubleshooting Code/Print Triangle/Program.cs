using System;

namespace _03.Printing_Triangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                PrintLine(1, i); 
            for (int j = 1; j <= n - 1; j++)
                PrintLine(1, n - j);
        }
        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}


