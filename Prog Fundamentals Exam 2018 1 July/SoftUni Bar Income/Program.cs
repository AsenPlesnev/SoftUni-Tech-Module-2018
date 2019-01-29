using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wholeInput = new List<string>();
            Regex rgx = new Regex(@"%(?<name>[A-Z][a-z]+)%[^\|\$%\.]*<(?<product>[A-Za-z]+)>[^\|\$%\.]*\|(?<counts>\d+)\|(?<price>[^\|\$%\.]*\.?\d+\$)");
            Regex priceRgx = new Regex(@"(?<realPrice>\d+\.?\d*)");
            string line = string.Empty;
            double sum = 0;

            while ((line = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in rgx.Matches(line))
                {
                    string Name = match.Groups["name"].Value;
                    string Product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["counts"].Value);
                    string textWithPrice = match.Groups["price"].Value;
                    double price = 0;
                    foreach (Match priceMatch in priceRgx.Matches(textWithPrice))
                    {
                        price = double.Parse(priceMatch.Groups["realPrice"].Value);
                    }
                    double currSum = quantity * price;

                    sum += currSum;

                    Console.WriteLine($"{Name}: {Product} - {currSum:f2}");
                }
            }
            Console.WriteLine($"Total income: {sum:f2}");
            
            
        
            
        }
    }
}
