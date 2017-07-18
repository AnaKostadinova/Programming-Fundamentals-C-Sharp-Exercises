using System;
using System.Collections.Generic;
using System.Linq;

class AverageCharacterDelimiter
{
    public static void Main()
    {
        string characters = Console.ReadLine();
        List<int> sum = new List<int>();
            for (int i = 0; i < characters.Length; i++)
            {
            sum.Add((int)(characters[i]));
            }
        sum.RemoveAll(e => e == 32);
        int average = sum.Sum() / sum.Count;
        char tempDelimiter = (char)average;
        char delimeter = char.ToUpper(tempDelimiter);
       string output = characters.Replace(' ',delimeter);
            Console.WriteLine(output);
        }
    }
   
        
  