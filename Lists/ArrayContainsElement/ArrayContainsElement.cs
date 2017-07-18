using System;
using System.Collections.Generic;
using System.Linq;

class ArrayContainsElement
{
    public static void Main()
    {
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == n)
            {
                counter++;
            }
        }
        if (counter > 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}