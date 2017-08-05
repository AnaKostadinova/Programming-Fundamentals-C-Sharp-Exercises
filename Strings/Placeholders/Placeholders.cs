using System;
using System.Collections.Generic;
using System.Linq;

namespace Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
            List<string> outputText = new List<string>();
            string leftPart = String.Empty;

            while (!text.Contains("end"))
            {
                leftPart = text[0];
                string[] elementsToReplaceWith = text[1]
                    .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < elementsToReplaceWith.Length; ++i)
                {
                    leftPart = leftPart.Replace("{" + i + "}", elementsToReplaceWith[i]);
                }

                Console.WriteLine(string.Join("\n", leftPart));

                text = Console.ReadLine().Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}