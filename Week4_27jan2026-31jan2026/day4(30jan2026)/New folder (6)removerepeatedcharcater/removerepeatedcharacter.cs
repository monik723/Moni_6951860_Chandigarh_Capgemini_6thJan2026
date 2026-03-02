using System;
using System.Collections.Generic;
using System.Text;

class UserProgramCode
{
    public static string RemoveRepeatedCharacters(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        HashSet<char> seen = new HashSet<char>();
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                result.Append(c);
            }
        }

        return result.ToString();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string output = UserProgramCode.RemoveRepeatedCharacters(input);
        Console.WriteLine("String after removing repeated characters:");
        Console.WriteLine(output);
    }
}
