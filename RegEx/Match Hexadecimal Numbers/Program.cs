using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";

            var numsAsString = Console.ReadLine();
            var nums = Regex.Matches(numsAsString, regex).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
