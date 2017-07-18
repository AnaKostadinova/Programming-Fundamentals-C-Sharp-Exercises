using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> c =new List<int>();
        for (int i = 0; i < a.Length - 1; i++)
        {
            int b = i + 1;
            while (b > 0)
            {
                if (a[b - 1] > a[b])
                {
                    a[b - 1] = a[b];
                    
                }
                a--;
            }
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}
