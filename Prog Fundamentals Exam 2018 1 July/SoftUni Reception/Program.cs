using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hoursPassed = 0;
            int wholeEfficiency = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            int totalStudents = 0;

            while (studentsCount > totalStudents)
            {

                totalStudents += wholeEfficiency;
                hoursPassed++;

                if (hoursPassed % 4 == 0)
                {
                    hoursPassed++;

                }
            }
            Console.WriteLine($"Time needed: {hoursPassed}h.");
        }
    }
}
