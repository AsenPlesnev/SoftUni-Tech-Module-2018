using System;
using System.Collections.Generic;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(",;:.!()\"'\\/[] "
                .ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();
            List<string> upper = new List<string>();

            for (int i = 0; i <input.Length; i++)
            {
                string current = input[i];
                if(IsLower(current))
                {
                    lower.Add(current);
                }
                else if (IsUpper(current))
                {
                    upper.Add(current);
                }
                else
                {
                    mixed.Add(current);
                }
            }
            Console.WriteLine("Lower-case: {0}", String.Join(", ", lower));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upper));

        }

        static bool IsUpper(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || 'Z' < symbol)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLower(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || 'z' < symbol)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
