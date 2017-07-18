using System;
using System.Collections.Generic;
using System.Linq;

public class SplitByWordCasing
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] counter = new int[numbers.Max() + 1];

        foreach (int num in numbers)
        {
            counter[num]++;
        }
        for (int i = 0; i < counter.Length; i++)
        {
            if (counter[i] != 0)
            {
                Console.WriteLine("" + i + " -> " + counter[i]);
            }
        }
    }
}
/*
 List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        numbers.Sort();
        int[] b = new int[numbers.Count];
        int counter = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            counter++;

            b[i] = numbers[i];
            b[i] = numbers.Count(x => x == numbers[i]);
            Console.WriteLine("" + numbers[i] + " -> " + b[i]);

            if (counter == numbers.Count)
            {
                break;
            }
            while (numbers[i] == numbers[i + 1])
            {
                numbers.Remove(numbers[i]);
                if (counter == numbers.Count)
                {
                    break;
                }

    */