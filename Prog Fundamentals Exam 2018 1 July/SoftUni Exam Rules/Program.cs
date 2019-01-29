using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Rules
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            string line = String.Empty;

            while ((line = Console.ReadLine()) != "exam finished")
            {
                
                string[] tokens = line.Split('-');
                if (tokens.Length == 2)
                {
                    string name = tokens[0];

                    if (participants.ContainsKey(name))
                    {
                        participants.Remove(name);
                    }
                }
                else if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!participants.ContainsKey(name))
                    {
                        participants.Add(name, points);
                    }
                    else
                    {
                        if (participants[name] <= points)
                        {
                            participants[name] = points;
                        }
                    }

                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 1);
                    }
                    else
                    {
                        languages[language]++;
                    }
                }
            }

            Console.WriteLine("Results:");
            foreach (var student in participants.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in languages.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
