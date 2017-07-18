using System;
using System.Collections.Generic;
using System.Linq;

public class UnunionLists
{
    public static void Main()
    {
        List<int> primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
        int a = int.Parse(Console.ReadLine());

        for (int i = 0; i < a; i++)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int j = 0; j < numbers.Count; j++)
            {
                if (primalList.Contains(numbers[j]))
                {
                    primalList.RemoveAll(e => e == numbers[j]);
                }
                else
                {
                    primalList.Add(numbers[j]);
                }
            }
        }

        primalList.Sort();
        Console.WriteLine(string.Join(" ", primalList));
    }
}