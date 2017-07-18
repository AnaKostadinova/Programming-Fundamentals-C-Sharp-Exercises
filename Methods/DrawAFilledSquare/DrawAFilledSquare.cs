using System;

namespace DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopAndBottomSymbols(number);
            PrintMiddleSymbols(number);
            PrintTopAndBottomSymbols(number);
        }

        public static void PrintMiddleSymbols(int number)
        {
            for (int i = 0; i < (number - 2); i++)
            {
                Console.Write('-');
                for (int j = 1; j < number; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        public static void PrintTopAndBottomSymbols(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }
    }
}

