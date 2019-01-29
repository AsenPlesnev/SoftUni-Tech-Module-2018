using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboards = lostGames / 3 / 2;
            int trashedDisplays = trashedKeyboards / 2;

            double totalPrice = trashedHeadsets * headsetPrice + trashedMouse * mousePrice + trashedKeyboards * keyboardPrice + trashedDisplays * displayPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
