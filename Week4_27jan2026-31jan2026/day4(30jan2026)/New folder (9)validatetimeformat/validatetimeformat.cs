using System;
using System.Text.RegularExpressions;

class UserProgramCode
{
    public static int IsValidTime(string input)
    {
        if (string.IsNullOrEmpty(input))
            return -1;

        // Pattern for hh:mm am/pm
        string pattern = @"^(0[1-9]|1[0-2]):[0-5][0-9]\s(am|pm)$";

        return Regex.IsMatch(input.ToLower(), pattern) ? 1 : -1;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter time in hh:mm am/pm format:");
        string input = Console.ReadLine();

        int result = UserProgramCode.IsValidTime(input);

        if (result == 1)
            Console.WriteLine("Valid time format.");
        else
            Console.WriteLine("Invalid time format.");
    }
}
