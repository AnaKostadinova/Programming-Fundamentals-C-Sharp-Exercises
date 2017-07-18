using System;
using System.Linq;


public class EqualSequenceOfElementsInArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        bool areEqual = true;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] != numbers[i + 1])
            {
                areEqual = false;
                break;
            }
            else
            {
                areEqual = true;
            }
        }
        if (areEqual)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}