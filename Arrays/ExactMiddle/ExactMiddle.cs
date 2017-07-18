using System.Linq;
using System;
using System.Collections.Generic;

public class ExactMiddle
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (numbers.Length == 1)
        {
            SingleNumber(numbers);
        }
        else if (numbers.Length == 3 || numbers.Length == 2)
        {
            Console.WriteLine("{ " + string.Join(", ", numbers) + " }");
        }
        else if (numbers.Length % 2 == 0)
        {
            EvenLength(numbers);
        }
        else if (numbers.Length % 2 != 0)
        {
            OddLength(numbers);
        }
    }

    public static void SingleNumber(int[] numbers)
    {
        int[] midNums = new int[numbers.Length / 2];
        if (numbers.Length == 1)
        {
            midNums = numbers;
            Console.WriteLine(string.Join("", midNums));
        }
    }

    public static void EvenLength(int[] numbers)
    {
        int[] midNums = new int[numbers.Length / 2];
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            if (numbers.Length % 2 == 0)
            {
                midNums[i] = numbers[i + (numbers.Length / 2 - 1)];
            }
        }
        Console.WriteLine('{' + $" {midNums[0]}, {midNums[1]} " + '}');
    }

    public static void OddLength(int[] numbers)
    {
        int[] midNums = new int[numbers.Length / 2 + 1];
        for (int i = 0; i < numbers.Length / 2 + 1; i++)
        {
            if (numbers.Length % 2 != 0)
            {
                midNums[i] = numbers[i + (numbers.Length / 2 - 1)];
            }
        }
        Console.WriteLine('{' + $" {midNums[0]}, {midNums[1]}, {midNums[2]} " + '}');
    }
}
