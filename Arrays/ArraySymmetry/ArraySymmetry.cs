using System;
using System.Linq;


    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();
            bool isSymmetrical = true;
            for (int i = 0; i < words.Length / 2; i++)
            {
                if (words[i] != words[words.Length - i - 1])
                {
                    isSymmetrical = false;
                    break;
                }
            }
            if (isSymmetrical)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
