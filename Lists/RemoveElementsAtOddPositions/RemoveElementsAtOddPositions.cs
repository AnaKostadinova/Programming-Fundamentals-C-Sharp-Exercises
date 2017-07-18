
using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsAtOddPositions
{
    public static void Main()
    {
        List<string> text = Console.ReadLine().Split(' ').ToList();
        List<string> elementsAtEvenPositions = new List<string>();

        for (int i = 0; i < text.Count; i++)
        {
            if (i % 2!= 0)
            {
                elementsAtEvenPositions.Add(text[i]);
            }
        }
        Console.WriteLine(string.Join("", elementsAtEvenPositions));
        }
    }

       
    
