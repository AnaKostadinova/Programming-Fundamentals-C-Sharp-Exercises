using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction
{
    public static void Main()
    {
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < a.Count; i++)
        {
            if (b.Contains(a[i]))
            {
                b.RemoveAll(e=>e==a[i]);
                }
        }
        if (a.Sum() == b.Sum())
        {
            Console.WriteLine("Yes. Sum: " + a.Sum());
        }
        else
        {
            Console.WriteLine("No. Diff: " + Math.Abs(a.Sum() - b.Sum()));
        }
    }
}

/*
  List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> b = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    if (a[i] == b[j])
                    {
                        b.RemoveAt(j);
                        j--;
                    }
                }
            }

            if (a.Sum() == b.Sum())
            {
                Console.WriteLine("Yes. Sum: " + a.Sum());
            }
            else
            {
                Console.WriteLine("No. Diff: " + Math.Abs(a.Sum() - b.Sum()));
            }
        }
        */
