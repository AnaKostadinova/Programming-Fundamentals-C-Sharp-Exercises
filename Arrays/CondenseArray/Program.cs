using System.Linq;
using System;
using System.Collections.Generic;

public class test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                for (char k = 'a'; k < 'a' + q; k++)
                {
                    for (char l = 'a'; l < 'a' + q; l++)
                    {
                        for (int m = 2; m <=n; m++)
                        {
                            Console.WriteLine("" + i + j + k + l + m + " ");
                        }
                    }

                }
            }
        }
    }
}
        
    

