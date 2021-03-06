﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split(" ").ToList();
            string input = "";

            while ((input = Console.ReadLine()) != "Play!")
            {
                string[] commands = input.Split().ToArray();
                string command = commands[0];
                string game = commands[1];

                if (command == "Install")
                {
                    if (!games.Contains(game))
                    {
                        games.Add(game);
                    }
                }
                else if (command == "Uninstall")
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                    }
                }
                else if (command == "Update")
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (command == "Expansion")
                {
                    string[] expansion = game.Split("-");
                    int index = games.IndexOf(expansion[0]);
                    if (games.Contains(expansion[0]))
                    {
                        games.Insert(index + 1, string.Join(":", expansion));
                    }

                }
            }
            Console.WriteLine(String.Join(" ", games));
        }
    }
}
