using System;

namespace BlankReceipt
{
    class BlankReceipt
    {
        public static void Main()
        {
            PrintReceiptHeader();
        }

        public static void PrintReceiptHeader()
        {
            string newLine = Environment.NewLine;
            Console.WriteLine($"CASH RECEIPT{newLine}" +
                              $"------------------------------");
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        public static void PrintReceiptBody()
        {
            string newLine = Environment.NewLine;
            Console.WriteLine($"Charged to____________________{newLine}" +
                              $"Received by___________________");
        }

        public static void PrintReceiptFooter()
        {
            string newLine = Environment.NewLine;
            char a = (char) 169;
            Console.WriteLine($"------------------------------{newLine}\u00A9 SoftUni");
        }
    }
}