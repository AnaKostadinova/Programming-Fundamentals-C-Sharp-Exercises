using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayUsingBubbleSort
{
    public static void Main()
    {
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] arr = a.ToArray();
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < a.Count - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
        Console.WriteLine(string.Join(" ", arr));
    }
}