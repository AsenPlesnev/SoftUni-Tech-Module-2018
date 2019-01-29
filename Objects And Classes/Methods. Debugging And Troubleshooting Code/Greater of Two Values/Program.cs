using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int MaxNumber = GetMax(firstNumber, secondNumber);
                Console.WriteLine(MaxNumber);
            }
            else if(type == "char")
            {
                char firstNumber = char.Parse(Console.ReadLine());
                char secondNumber = char.Parse(Console.ReadLine());
                char MaxNumber = GetMax(firstNumber, secondNumber);
                Console.WriteLine(MaxNumber);
            }
            else if(type == "string")
            {
                string firstNumber = Console.ReadLine();
                string secondNumber = Console.ReadLine();
                string MaxNumber = GetMax(firstNumber, secondNumber);
                Console.WriteLine(MaxNumber);
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
                return firstNumber;
            else return secondNumber;
        }

        static char GetMax(char firstSymbol, char secondSymbol)
        {
            if ((int)firstSymbol >= (int)secondSymbol) return firstSymbol;
            else return secondSymbol;
        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0) return firstString;
            else return secondString;
        }
    }
}
