using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = CalculatePow(number, power);
            Console.WriteLine(result);
        }

        static double CalculatePow(double number, int power)
        {
            double result = 0d;
            result = Math.Pow(number,power);
            return result;
        }
    }
}
