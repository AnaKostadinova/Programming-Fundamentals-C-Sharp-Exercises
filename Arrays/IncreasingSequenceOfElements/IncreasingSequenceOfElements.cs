using System;
using System.Linq;


    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isIncreasing = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (!(numbers[i] < numbers[i + 1]))
                {
                    isIncreasing = false;
                    break;
                }
            }
            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
