using System;
using System.Collections.Generic;
using System.Linq;


namespace TextFilter
{
   public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                    var asterix = new string('*', bannedWords[i].Length);
                    text = text.Replace(bannedWords[i], asterix);
                }
            }
            Console.WriteLine(text);       
        }
    }
}
