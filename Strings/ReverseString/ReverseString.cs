using System;
using System.Collections.Generic;
using System.Linq;


namespace ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] a = input.ToCharArray();
            char[] b = new char [a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[a.Length - 1 - i];
            }
            Console.WriteLine(b);
        }
    }
}