using System;
using System.Linq;


namespace CountOfOddNumbersInArray
{
    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1||numbers[i] % 2 == -1)
                    counter++;
            }
            Console.WriteLine(counter);
        }        
        }
    }

