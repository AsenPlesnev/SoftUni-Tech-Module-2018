using System;

namespace Days_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            if(n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else Console.WriteLine(DaysOfWeek[n-1]);
        }
    }
}
