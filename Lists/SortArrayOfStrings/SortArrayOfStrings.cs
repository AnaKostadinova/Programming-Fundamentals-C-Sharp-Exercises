using System;
using System.Collections.Generic;
using System.Linq;

    class SortArrayOfStrings
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int stringElementsDiff = arr[i].CompareTo(arr[i + 1]);
                if (stringElementsDiff > 0) { 
                        string temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            Console.WriteLine(string.Join(" ", arr));
    }
}
