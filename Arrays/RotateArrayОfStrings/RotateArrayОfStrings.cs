using System;
using System.Linq;


namespace RotateArrayОfStrings
{
    public class RotateArrayОfStrings
    {
        public static void Main()
        {
            string[] a = Console.ReadLine().Split();

            string[] rotatedArray = new string[a.Length];

            for (int i = 0; i < a.Length-1; i++)
            {
                rotatedArray[i + 1] = a[i];
            }
            string lastElement = a[rotatedArray.Length - 1];
            rotatedArray[0] = lastElement;

            Console.WriteLine(string.Join(" ", rotatedArray));
        }        
        }
    }

