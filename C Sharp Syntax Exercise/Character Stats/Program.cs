using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int current_health = int.Parse(Console.ReadLine());
            int max_health = int.Parse(Console.ReadLine());
            int current_energy = int.Parse(Console.ReadLine());
            int max_energy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.Write("|");
            if (current_health < max_health)
            {
                for (int i = 1; i <= current_health; i++) Console.Write("|");
                for (int j = 0; j < max_health - current_health; j++) Console.Write("."); 
            }
            else for (int i = 1; i <= max_health; i++) Console.Write("|");
            Console.WriteLine("|");
            Console.Write("Energy: ");
            Console.Write("|");
            if (current_energy < max_energy)
            {
                for (int i = 1; i <= current_energy; i++) Console.Write("|");
                for (int j = 0; j < max_energy - current_energy; j++) Console.Write(".");
            }
            else for (int i = 1; i <= max_energy; i++) Console.Write("|");
            Console.WriteLine("|");
        }
    }
}
