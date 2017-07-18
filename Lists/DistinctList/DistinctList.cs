using System;
using System.Collections.Generic;
using System.Linq;

public class DistinctList
{
    public static void Main()
    {
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < a.Count; i++)
        {
            for (int j = i+1; j < a.Count; j++)
            {
                if (a[i] == a[j])
                {
                    a.RemoveAt(j);
                    j--;
                }
            }
        }
        Console.WriteLine(string.Join(" ", a));
    }
}


/*
List<string> a = Console.ReadLine().Split().ToList();
HashSet<string> b = new HashSet<string>(a);
Console.WriteLine(string.Join(" ", b));
}
}
*/