using System;

namespace Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT" + Environment.NewLine + new string('-',30));

        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________" + Environment.NewLine + "Received by___________________");
        }

        static void PrintFooter()
        {

            Console.WriteLine(new string('-',30) + Environment.NewLine + '©' + " SoftUni");
        }
    }
}
