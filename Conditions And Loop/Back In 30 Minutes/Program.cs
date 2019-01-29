using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newmin = minutes + 30;
            if(newmin > 60)
            {
                hour = hour + 1;
                newmin = newmin - 60;
            }
            if(newmin == 60)
            {
                hour = hour + 1;
                newmin = 0;
            }
            if (hour == 24) hour = 0;
            Console.WriteLine($"{hour}:{newmin:d2}");
        }
    }
}
