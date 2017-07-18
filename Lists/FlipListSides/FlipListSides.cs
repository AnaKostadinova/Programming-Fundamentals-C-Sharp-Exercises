using System;
using System.Collections.Generic;
using System.Linq;

public class FlipListSides
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> flippedNumbers = new List<int>();
        int firstElement = numbers[0];
        int lastElement = numbers[numbers.Count - 1];
        for (int i = numbers.Count - 2; i > 0; i--)
        {
            flippedNumbers.Add(numbers[i]);
        }
        Console.WriteLine("" + firstElement + " " + string.Join(" ",flippedNumbers) + " " + lastElement);

        }
    }



    
