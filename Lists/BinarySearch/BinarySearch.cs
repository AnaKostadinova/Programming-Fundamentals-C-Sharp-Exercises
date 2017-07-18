using System;
using System.Collections.Generic;
using System.Linq;

    class BinarySearch
    {
        public static void Main()
        {
           List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int target = int.Parse(Console.ReadLine());
        int[] rightHalf = new int[numbers.Count/2];

        numbers.Sort();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[numbers.Count / 2] < target)
                {
                    rightHalf[i] = numbers[numbers.Count / 2 + i];
                }

                if (!(numbers[numbers.Count / 2] < target))
                    {
                numbers[numbers.Count / 2] = target;
                    }
                    {
                        if (rightHalf[rightHalf.Length / 2] < target)
                        {
                            rightHalf[i] = rightHalf[rightHalf.Length / 2 + i];
                        }
                        else
                        {
                            rightHalf[rightHalf.Length / 2] = target;
                        }
                    }
                }
            }

        }        
        
 