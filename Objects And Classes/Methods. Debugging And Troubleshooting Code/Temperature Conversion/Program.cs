using System;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit = double.Parse(Console.ReadLine());
            double result = FahrenheitToCelsius(Fahrenheit);
            Console.WriteLine($"{result:f2}");
        }

        static double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }
    }
}
