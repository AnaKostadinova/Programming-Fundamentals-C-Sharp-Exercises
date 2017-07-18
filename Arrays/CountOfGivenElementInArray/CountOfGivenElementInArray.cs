using System;
using System.Linq;

public class CountOfGivenElementInArray
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int specialNumber = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] ==specialNumber)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}