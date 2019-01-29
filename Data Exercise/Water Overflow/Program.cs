using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int capacity = 0;
            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                capacity += liters;
                if (capacity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity -= liters;
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
