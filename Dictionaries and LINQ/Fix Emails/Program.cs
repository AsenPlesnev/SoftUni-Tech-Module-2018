using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    foreach (var kvp in emails)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                    break;
                }
                string email = Console.ReadLine().ToLower();

                bool contains = Regex.IsMatch(email, @"\b.us\b");
                bool contains1 = Regex.IsMatch(email, @"\b.uk\b");
                if (contains == false && contains1 == false)
                {
                    if (!emails.ContainsKey(name))
                    {
                        emails.Add(name, email);
                    }
                    emails[name] = email;
                }

            
            }
        }
    }
}
