namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            for (int i = lists.Count - 1; i >= 0; i--)
            {
                string[] currentList = lists[i].Split(new char[] {' '}, 
                    StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currentList.Length; j++)
                {
                    Console.Write(currentList[j] + " ");
                }
            }
        }
    }
}
/*
 *     using System;
    using System.Collections.Generic;
    using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> lists = Console.ReadLine().Split('|').ToList();
        lists.Reverse();
        string[] a = new string[lists.Count];
        for (int i = 0; i < lists.Count; i++)
        {
            a[i] = lists[i].Trim();
        }
        Console.Write(string.Join(" ",a));

            }
    }


*/