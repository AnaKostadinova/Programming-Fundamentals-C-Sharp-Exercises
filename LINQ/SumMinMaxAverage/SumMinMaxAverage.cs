using System;
using System.Collections.Generic;
using System.Linq;

public class SumMinMaxAverage
{
    public static void Main()
    {
        List<int> numbers = new List<int>();
        int a = int.Parse(Console.ReadLine());

        for (int i = 0; i < a; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            numbers.Add(currentNumber);
        }

        Console.WriteLine($"Sum = {numbers.Sum()}\n" +
                          $"Min = {numbers.Min()}\n" +
                          $"Max = {numbers.Max()}\n" +
                          $"Average = {numbers.Average()}");
    }
}