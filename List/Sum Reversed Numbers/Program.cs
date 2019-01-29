using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            ReverseNumbers(nums);
            int total = nums.Sum();
            Console.WriteLine(total);
           
        }

        private static void ReverseNumbers(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                int left = nums[i];
                int digit;
                int rev = 0;
                while (left > 0)
                {
                    digit = left % 10;
                    rev = rev * 10 + digit;
                    left = left / 10;
                }
                nums[i] = rev;
            }
        }
    }
}
