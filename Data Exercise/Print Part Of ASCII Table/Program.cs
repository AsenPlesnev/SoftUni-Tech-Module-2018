using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartingIndex = int.Parse(Console.ReadLine());
            int LastIndex = int.Parse(Console.ReadLine());
            for(int i = StartingIndex; i <= LastIndex; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
    }
}
