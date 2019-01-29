using System;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double esp = 0.000001;
            double diff;
            if (num1 > num2)
            {
                diff = num1 - num2;
            }
            else diff = num2 - num1;
            if (diff <= esp) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
