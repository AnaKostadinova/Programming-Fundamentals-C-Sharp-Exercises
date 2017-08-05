using System;
using System.Collections.Generic;
using System.Linq;


namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string[] text = Console.ReadLine()
                .Split(new char[] {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            List<string> a = new List<string>();

            foreach (string word in text)
            {
                char[] array = word.ToCharArray();
                Array.Reverse(array);
                string reveresedPalindrome = new string(array);
                if (word.Equals(reveresedPalindrome))
                {
                    palindromes.Add(word);
                }
            }
            palindromes = palindromes
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < palindromes.Count; i++)
            {

                int result = string.Compare(palindromes[i], palindromes[i + 1], false);

                if (result != 0)
                {
                    a.Add(palindromes[i]);
                    a.Add(palindromes[i + 1]);
                }
            }
            
                
           
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}