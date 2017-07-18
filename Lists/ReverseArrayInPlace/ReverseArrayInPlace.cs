using System;
using System.Collections.Generic;
using System.Linq;

    class ReverseArrayInPlace
    {
        public static void Main()
        {
            List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            a.Reverse();
            Console.WriteLine(string.Join(" ", a));
        }
}
   