using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Odd")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (input == "Even")
                {
                    foreach (int number in numbers)
                    {
                        if(number % 2 == 0)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                string[] line = input.Split(' ');
                string command = line[0];
                switch (command)
                {
                    case "Delete":
                        int numberToRemove = int.Parse(line[1]);
                        numbers.RemoveAll(n => n == numberToRemove);
                        break;
                    case "Insert":
                        int elemnet = int.Parse(line[1]);
                        int position = int.Parse(line[2]);
                        numbers.Insert(position, elemnet);
                        break;
                }
            }
        }
    }
}
