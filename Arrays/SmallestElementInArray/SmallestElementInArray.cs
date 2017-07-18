using System;
using System.Linq;


namespace SmallestElementInArray
{
    public class SmallestElementInArray
    {
        public static void Main()
        {
            int min = Int32.MaxValue;
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                    .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min=numbers[i];
                }
            }
            Console.WriteLine(min);
        }        
        }
    }

/*
 *  var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var min = numbers.Min();
            Console.WriteLine(min);
        }
    }
}
*/
 /*
using System.Linq;
using System;
using System.Collections.Generic;

public class test
{
    public static void Main()
    {
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(a.Min());
    }
}
*/