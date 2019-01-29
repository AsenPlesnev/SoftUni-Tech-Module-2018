using System;
using System.Linq;
using System.Collections.Generic;

namespace Miners_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    foreach (var kvp in resources)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += quantity;
            }
        }
    }
}
