using System;
using System.Linq;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
                string[] tokens = line.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "A":
                        string name = tokens[1];
                        string phone = tokens[2];
                        AddPhone(phonebook, name, phone);
                        break;

                    case "S":
                        string searchedName = tokens[1];
                        SearchNumber(phonebook, searchedName);
                        break;
                    case "ListAll":
                        foreach (var kvp in phonebook)
                        {
                            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                        }
                        break;
                }

            }
        }

        private static void SearchNumber(SortedDictionary<string, string> phonebook, string searchedName)
        {
            if (phonebook.ContainsKey(searchedName))
            {
                string phoneNumber = phonebook[searchedName];
                Console.WriteLine($"{searchedName} -> {phoneNumber}");
            }
            else
            {
                Console.WriteLine($"Contact {searchedName} does not exist.");
            }
        }

        private static void AddPhone(SortedDictionary<string, string> phonebook, string name, string phone)
        {
            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, phone);
            }
            else
            {
                phonebook[name] = phone;
            }
        }
    }
}
