using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
       public static void Main(string[] args)
        {
            PrintReceiptHeader();
        }
        static void PrintReceiptHeader()
        {
            string newLine = Environment.NewLine;
            Console.WriteLine($"CASH RECEIPT{newLine}" +
                              $"------------------------------");
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptBody()
        {
            string newLine = Environment.NewLine;
            Console.WriteLine($"Charged to____________________{newLine}" +
                              $"Received by___________________");
        }

        static void PrintReceiptFooter()
        {
            string newLine = Environment.NewLine;
            Console.WriteLine($"------------------------------{newLine}" +  '\u00a9'+ " SoftUni");}
        }
    }

     