using System;
using System.Collections.Generic;
using System.Linq;

    class TearListInHalf
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> newList = new List<int>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                int a = numbers[i + (numbers.Count / 2)] / 10;
                int b = numbers[i + (numbers.Count / 2)] % 10;
            newList.Add(a);
            newList.Add(numbers[i]);
            newList.Add(b);
                }
            Console.WriteLine(string.Join(" ",newList));

    }
}
   