using System;
using System.Collections.Generic;
using System.Linq;

    class SmallestElementInArray
    {
        public static void Main()
        {
            List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] numbers = a.ToArray();

        int min = Int32.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine(min);
        }
}
   