using System;


namespace Arrays
{
    public class SumArrayElements
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbersToAdd = new int[number];
            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbersToAdd[i] = currentNumber;
            }
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += numbersToAdd[i];
            }
            Console.WriteLine(sum);
        }        
        }
    }

/*using System.Linq;
using System;
using System.Collections.Generic;

public class test
{
    public static void Main()
    {
        int numberOfelements = int.Parse(Console.ReadLine());
        int[] elements = new int[numberOfelements];
        int sum = 0;

        for (int i = 0; i < numberOfelements; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
            sum += elements[i];
        }

        Console.WriteLine(sum);
    }
}
*/

