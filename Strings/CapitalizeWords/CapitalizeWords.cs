using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] elements = input.Split(new char[]
                        {'!', '?', '.', ',', ':', ';', '-', '[', ']', '(', ')', '\\', '/', '\"', ' ', '}', '{'},
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string firstLetter = elements[i].Substring(0, 1);

                    elements[i] = firstLetter.ToUpper() + elements[i].Substring(1).ToLower();
                }
                Console.WriteLine($"{string.Join(", ", elements)}");

                input = Console.ReadLine();
            }
        }
    }
}