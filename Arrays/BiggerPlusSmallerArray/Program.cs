using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] c = new int [Math.Max(a.Length, b.Length)];
        int d = Math.Max(a.Length, b.Length);
        for (int i = 0; i < d; i++)
        {
            if (a.Length == b.Length)
            {
                c[i] = a[i] + b[i];
            }
            else
            {
                c[i] = Math.Max(a[i % a.Length], b[i % b.Length])
                       + Math.Min(a[i % a.Length], b[i % b.Length]);
            }
        }
        Console.WriteLine(string.Join(" ", c));
    }
}