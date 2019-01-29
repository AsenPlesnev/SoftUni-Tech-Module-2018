﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "print")
                {
                    Console.WriteLine("[{0}]", String.Join(", ", nums));
                    break;
                }
                string[] tokens = line.Split();
                string command = tokens[0];
                int index;
                int element;
                switch (command)
                {
                    case "add":
                        index = int.Parse(tokens[1]);
                        element = int.Parse(tokens[2]);
                        nums.Insert(index, element);
                        break;
                    case "addMany":
                        addMany(nums, tokens);
                        break;
                    case "contains":
                        element = int.Parse(tokens[1]);
                        index = nums.IndexOf(element);
                        Console.WriteLine(index);
                        break;
                    case "remove":
                        index = int.Parse(tokens[1]);
                        nums.RemoveAt(index);
                        break;
                    case "shift":
                        int rotations = int.Parse(tokens[1]);
                        shift(rotations, nums);
                        break;
                    case "sumPairs":
                        sumPairs(nums);
                        break;
                }
            }
        }

        private static void sumPairs(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                nums[i] += nums[i + 1];
                nums.RemoveAt(i + 1);

            }
        }

        private static void shift(int rotations, List<int> nums)
        {
            for (int i = 0; i < rotations % nums.Count; i++)
            {
                int first = nums[0];
                nums.RemoveAt(0);
                nums.Add(first);
            }
        }

        private static void addMany(List<int> nums, string[] tokens)
        {
            int index = int.Parse(tokens[1]);
            List<int> numsToAdd = new List<int>();
            for (int i = 2; i < tokens.Length; i++)
            {
                numsToAdd.Add(int.Parse(tokens[i]));
            }
            nums.InsertRange(index, numsToAdd);
        }
    }
}
