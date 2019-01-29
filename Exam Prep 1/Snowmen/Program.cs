using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Snowballs
{
    class Program
    {
        const int MARKED_FOR_DELETION = -1;

        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

            var report = FightReport(sequence);
            Console.WriteLine(report);
        }

        static string FightReport(List<int> sequence)
        {
            string strToReturn = string.Empty;
            while (sequence.Count > 1)
            {
                for (int attacker = 0; attacker < sequence.Count; attacker++)
                {
                    // integer value is its target index
                    int target = sequence[attacker];
                    // If the integer value is greater than the length of the sequence, divide it modulo (%) by the length of the sequence
                    if (target >= sequence.Count)
                    {
                        target = sequence[attacker] % sequence.Count;
                    }

                    // The process must be repeated until there is 1 snowman left in the sequence.
                    var numberOfItemsNotMarkedForDeletion = sequence.Where(x => x != MARKED_FOR_DELETION).Count();
                    if (numberOfItemsNotMarkedForDeletion == 1)
                    {
                        break;
                    }

                    // The item is already deleted so miss it
                    if (target == MARKED_FOR_DELETION)
                    {
                        continue;
                    }

                    int looser = attacker;
                    if (attacker == target)
                    {
                        strToReturn += string.Format("{0} performed harakiri\n", attacker);
                    }
                    else
                    {
                        int difference = Math.Abs(attacker - target);
                        if (difference % 2 == 0)
                        {
                            looser = target;
                            strToReturn += string.Format("{0} x {1} -> {0} wins\n", attacker, target);
                        }
                        else
                        {
                            strToReturn += string.Format("{0} x {1} -> {1} wins\n", attacker, target);
                        }
                    }
                    // Mark the looser, so we can delete him later
                    sequence[looser] = MARKED_FOR_DELETION;
                }
                // When you finish traversing the whole sequence, you must remove all elements that have lost or suicided, and then you must start over
                sequence.RemoveAll(isMarkedForDeletion);
            }
            return strToReturn;
        }

        private static bool isMarkedForDeletion(int i)
        {
            return i == MARKED_FOR_DELETION;
        }

    }
}