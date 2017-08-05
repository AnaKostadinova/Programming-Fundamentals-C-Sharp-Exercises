using System;
using System.Linq;


namespace CharRotation
{
    public class CharRotation
    {
        public static void Main()
        {
            string symbols = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += (char)(symbols[i] - numbers[i]);
                }
                else
                {
                    result += (char)(symbols[i] + numbers[i]);
                }
            }
            Console.WriteLine(result);
        }        
        }
    }

