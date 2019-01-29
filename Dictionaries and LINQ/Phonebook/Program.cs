using System;
using System.Linq;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                }

            }
        }

        private static void SearchNumber(Dictionary<string, string> phonebook, string searchedName)
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

        private static void AddPhone(Dictionary<string, string> phonebook, string name, string phone)
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
