using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int output = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(output);

        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int lastDigit = number % 10;
                if(lastDigit%2 !=0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }
    }
}
