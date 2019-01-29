using System;

namespace Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception err)
            {
                Console.WriteLine("Invalid input!");
            }


        }
    }
}
