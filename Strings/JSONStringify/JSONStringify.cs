using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JSONStringify
{
    public class JSONStringify
    {
        public static void Main()
        {
            string studentsData = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            while (studentsData != "stringify")
            {
                string[] elements = studentsData.Split(new char[] {' ', ',', '.', ':', '-', '>'},
                    StringSplitOptions.RemoveEmptyEntries);
                string name = elements[0];
                int age = int.Parse(elements[1]);
                List<int> grades = elements.Skip(2).Select(int.Parse).ToList();

                if (output.Length > 0)
                {
                    output.Append(',');
                }

                output.Append('{' + $"name:\"{name}\",age:{age},grades:[{string.Join(", ", grades)}]" + '}');

                studentsData = Console.ReadLine();
            }

            Console.WriteLine($"[{output.ToString()}]");
        }
    }
}