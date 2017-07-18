namespace TrickyStrings
{
    using System;
    using System.Collections.Generic;

    public class TrickyStrings
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool[] num = new bool[a + 1];
            for (int i = 2; i < a; i++)
            {
                num[i] = true;
            }
            for (int i = 2; i < a; i++)
            {
                if (num[i])
                {
                    Console.WriteLine(i);
                    int p = 2 * i;
                    while (p <= a)
                    {
                        num[p] = false;
                        p = p + i;
                    }
                }
            }
        }
    }
}