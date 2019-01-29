using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> splittedInput = input.Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "3:1")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        if (endIndex < 0 || startIndex > splittedInput.Count - 1)
                        {
                            continue;
                        }

                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        if (endIndex > splittedInput.Count)
                        {
                            endIndex = splittedInput.Count - 1;
                        }

                        string result = String.Empty;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            result += splittedInput[i];

                        }
                        splittedInput.RemoveRange(startIndex, endIndex - startIndex);
                        splittedInput.Insert(startIndex, result);
                        break;
                    case "divide":
                        int index = int.Parse(tokens[1]);
                        int partitions = int.Parse(tokens[2]);
                        break;
                }

                Console.WriteLine(String.Join(" ", splittedInput));
            }
        }
    }
}
