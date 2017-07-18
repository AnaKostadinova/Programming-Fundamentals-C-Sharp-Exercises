using System;
using System.Linq;


namespace LargestElementInArray
{
    public class LargestElementInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int maxNumber = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
                Console.WriteLine(maxNumber);
                    
        }
    }
}
