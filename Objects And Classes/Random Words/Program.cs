using System;
using System.Linq;

namespace Random_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length-1);
                var current = words[i];
                words[i] = words[index];
                words[index] = current;
            }

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
