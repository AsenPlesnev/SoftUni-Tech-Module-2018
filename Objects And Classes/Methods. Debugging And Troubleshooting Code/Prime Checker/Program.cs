using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long number)
        {
            bool IsPrime = true;
            if(number == 0 || number == 1)
            {
                IsPrime = false;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            return IsPrime;
        }
    }
}
