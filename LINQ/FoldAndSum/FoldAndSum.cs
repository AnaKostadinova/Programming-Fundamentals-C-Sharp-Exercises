using System;
using System.Collections.Generic;
using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] leftNums = numbers.Take(numbers.Length/4).Reverse().ToArray();
            int[] righttNums = numbers.Reverse().Take(numbers.Length/4).ToArray();
            int[] rightAndLeftNums = leftNums.Concat(righttNums).ToArray();
            numbers = numbers.Skip(numbers.Length / 4).Take(2 * numbers.Length / 4).ToArray();
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i] + rightAndLeftNums[i];
            }
            Console.WriteLine(string.Join(" ",result));       
        }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] leftNums = numbers.Take(numbers.Length / 4).Reverse().ToArray();
        int[] righttNums = numbers.Reverse().Take(numbers.Length / 4).ToArray();
        int[] rightAndLeftNums = leftNums.Concat(righttNums).ToArray();
        numbers = numbers.Skip(numbers.Length / 4).Take(2 * numbers.Length / 4).ToArray();

        int[] result = new int[numbers.Length];
        result = rightAndLeftNums.Select((n, index) => n + numbers[index]).ToArray();
        Console.WriteLine(string.Join(" ", result));
    }
}
*/


