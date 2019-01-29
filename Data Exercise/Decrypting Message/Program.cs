using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte count = byte.Parse(Console.ReadLine());
            string result = "";
            for(int i = 1; i <= count; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                symbol = (char)((int)symbol + key);
                result += symbol;
            }
            Console.WriteLine(result);
        }
    }
}
