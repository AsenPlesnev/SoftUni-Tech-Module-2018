using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double sabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double sabersMoney = sabers * Math.Ceiling((double)student * 1.1);
            double robesMoney = robes * student;
            double beltsMoney = belts * (student - student / 6);

            double totalMoney = sabersMoney + robesMoney + beltsMoney;

            if (totalMoney > money)
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney - money:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }

        }
    }
}
