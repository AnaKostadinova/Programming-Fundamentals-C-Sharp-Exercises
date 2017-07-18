using System;
using System.Linq;


namespace OddNumbersAtOddPositions
{
    public class OddNumbersAtOddPosition
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i % 2 != 0) && ((numbers[i] % 2 == 1) || (numbers[i] % 2 == -1)))
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }
        }
    }
}
