using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayUsingInsertionSort
{
    public static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int a = i + 1;
                while (a > 0)
                {
                    if (arr[a - 1] > arr[a])
                    {
                        int temp = arr[a];
                        arr[a] = arr[a - 1];
                        arr[a - 1] = temp;
                    }
                    a--;
                    }
                }
            Console.WriteLine(string.Join(" ", arr));
        }
    }


