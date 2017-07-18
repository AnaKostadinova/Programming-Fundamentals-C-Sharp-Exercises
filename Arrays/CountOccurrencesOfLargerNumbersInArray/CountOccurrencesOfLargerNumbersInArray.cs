using System;
using System.Linq;


    public class CountOccurrencesOfLargerNumbersInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double p = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }        
        }
    

