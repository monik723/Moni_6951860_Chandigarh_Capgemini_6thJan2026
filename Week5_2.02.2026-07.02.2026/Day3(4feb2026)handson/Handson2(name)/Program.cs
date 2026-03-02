using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input1 = "Hi how are you";
        string input2 = "Aryan";   // ❌ less than 15 characters

        string combinedInput = input1 + " Dear " + input2;

        string pattern = @"^Hi how are you Dear [A-Za-z]{16,}$";

        if (Regex.IsMatch(combinedInput, pattern))
        {
            Console.WriteLine("Valid Pattern");
        }
        else
        {
            Console.WriteLine("Invalid Pattern");
        }

        Console.WriteLine(combinedInput);
    }
}
