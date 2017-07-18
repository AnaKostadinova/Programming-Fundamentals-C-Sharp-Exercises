using System;
using System.Collections.Generic;
using System.Linq;

public class StringEncryption
{
    public static void Main()
    {
        int numberOfLetters = int.Parse(Console.ReadLine());
        string result = String.Empty;
        for (int i = 0; i < numberOfLetters; i++)
        {
            char letter = char.Parse(Console.ReadLine());

            result += (SumLetterAndLastDigit(letter)
                       + AppendFirstAndLastDigit(letter)
                       + SubtractFirstFromLetter(letter));
        }
        Console.WriteLine(result);
    }

    public static string SumLetterAndLastDigit(char letter)
    {
        string result = String.Empty;
        int sum = 0;
        int lastDigit = 0;
        if (((int) letter >= 10 && (int) letter <= 99)
            || (int) letter >= 100 && (int) letter <= 999)
        {
            lastDigit = letter % 10;
        }
        sum = letter + lastDigit;
        result = "" + (char) sum;
        return result;
    }

    public static string AppendFirstAndLastDigit(char letter)
    {
        string middle = String.Empty;
        int firstDigit = 0;
        int lastDigit = 0;
        if (((int) letter >= 10 && (int) letter <= 99))

        {
            firstDigit = (letter / 10);
            lastDigit = letter % 10;
        }
        else if ((int) letter >= 100 && (int) letter <= 999)
        {
            firstDigit = letter / 100;
            lastDigit = letter % 10;
        }
        middle = "" + firstDigit + lastDigit;
        return middle;
    }

    public static string SubtractFirstFromLetter(char letter)
    {
        string result = String.Empty;
        int quotient = 0;
        int firstDigit = 0;
        if (((int) letter >= 10 && (int) letter <= 99))
        {
            firstDigit = letter / 10;
        }
        else if ((int) letter >= 100 && (int) letter <= 999)
        {
            firstDigit = letter / 100;
        }
        quotient = letter - firstDigit;
        result = "" + (char) quotient;
        return result;
    }
}