using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Extract_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedWord = Console.ReadLine();

            string pattern = $@"\b{searchedWord}\b";

            Regex regex = new Regex(pattern);

            string[] sentences = Console.ReadLine().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();

            foreach (string word in sentences)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
