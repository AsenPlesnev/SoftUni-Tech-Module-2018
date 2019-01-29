using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    public class MatchFullName
    {
        public static void Main()
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
            
        }
    }
}