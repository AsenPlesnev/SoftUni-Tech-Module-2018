using System;
using System.Linq;
using System.Collections.Generic;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();
                string[] username = tokens[2].Split('=');
                string name = username[1];

                string[] ips = tokens[0].Split('=');
                string ip = ips[1];
                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }
                if ()
                {

                }


            }
            
        }
    }
}
