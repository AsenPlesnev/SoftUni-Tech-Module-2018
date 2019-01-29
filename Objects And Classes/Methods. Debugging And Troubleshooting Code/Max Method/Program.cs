using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = int.Parse(Console.ReadLine());
            int Number2 = int.Parse(Console.ReadLine());
            int Number3 = int.Parse(Console.ReadLine());
            int MaxNumber = GetMax(Number1, Number2);
            MaxNumber = GetMax(MaxNumber, Number3);
            Console.WriteLine(MaxNumber);
        }

        private static int GetMax(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number1;
            }
            return number2;
        }
    }
}
