using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningCoins_Broken
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += CheckAndEncrypt(letter);
            }
            Console.WriteLine(result);
        }

        private static string CheckAndEncrypt(char letter)
        {
            if ((int)letter >= 10 && (int)letter <= 99)
            {
                var digit1 = letter / 10;
                var digit2 = letter % 10;
                return Encrypt(digit1, digit2, letter);
            }
            else if ((int)letter >= 100 && (int)letter <= 999)
            {
                var digit1 = letter / 100;
                var digit2 = letter % 10;
                return Encrypt(digit1, digit2, letter);
            }
            else return string.Empty;
        }

        private static string Encrypt(int digit1, int digit2, char letter)
        {
            string result = string.Empty;
            var firstAndLastDigits = (digit1 * 10 + digit2);
            var start = (char)((int)letter + digit2);
            var end = (char)((int)letter - digit1);
            result = start.ToString();
            result += firstAndLastDigits.ToString();
            result += end.ToString();
            return result;
        }

    }
}