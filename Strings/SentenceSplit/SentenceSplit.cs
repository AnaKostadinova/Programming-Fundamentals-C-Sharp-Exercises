using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string output = sentence.Replace(delimeter, ", ");

            Console.WriteLine($"[{output.ToString()}]");
        }
    }
}