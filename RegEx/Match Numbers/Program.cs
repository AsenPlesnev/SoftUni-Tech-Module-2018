using System;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numsAsString = Console.ReadLine();

            var nums = Regex.Matches(numsAsString, regex);

            foreach (Match number in nums)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
