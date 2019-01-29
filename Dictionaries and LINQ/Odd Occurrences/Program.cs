using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word]++;
                }
            }

            List<string> oddCount = new List<string>();
            foreach (var kvp in words)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddCount.Add(kvp.Key);
                }
            }

            Console.WriteLine(String.Join(", ", oddCount));
        }
    }
}
