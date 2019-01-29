using System;


namespace SoftUniHomework01Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ProductName = Console.ReadLine();
            var ProductVolume = int.Parse(Console.ReadLine());
            var ProductEnergy = int.Parse(Console.ReadLine());
            var ProductSugarContent = double.Parse(Console.ReadLine());

            var energy = (ProductVolume * ProductEnergy) / 100.00;

            var sugar = (ProductSugarContent * ProductVolume) / 100.00;

            Console.WriteLine($"{ProductVolume}ml {ProductName}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}