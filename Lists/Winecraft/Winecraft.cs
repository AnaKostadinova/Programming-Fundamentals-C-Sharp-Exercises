using System;
using System.Collections.Generic;
using System.Linq;

class Winecraft
{
    public static void Main()
    {
        List<int> grapes = Console.ReadLine().Split().Select(int.Parse).ToList();
        int growthDays = int.Parse(Console.ReadLine());

        int grapesLength = grapes.Count;
        for (int i = 0; i < growthDays; i++)
        {
            for (int j = 0; j < grapes.Count + 1; j++)
            {
                if (j == grapes.Count - 1 && grapes[j] < grapes[j - 1])
                {
                    grapes[j]--;
                    break;
                }


                if ((grapes[j] < grapes[j + 1]))
                {
                    grapes[j]--;
                }
               else if (j > 0 && grapes[j] > grapes[j - 1] && grapes[j] > grapes[j + 1]
                    && grapes[j-1]<grapes[j-2])
                {
                    grapes[j] += 3;
                    grapes[j - 1]--;
                }
               
                
                else if (j > 0 && grapes[j] < grapes[j - 1] && grapes[j] < grapes[j - 2])
                {
                    grapes[j]--;
                }
                else
                {
                    grapes[j]++;
                }
            }
        }
    }
}