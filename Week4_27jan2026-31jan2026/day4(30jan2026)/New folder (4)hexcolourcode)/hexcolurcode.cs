using System;
using System.Text.RegularExpressions;

class UserProgramCode
{
    public static bool IsValidHexColor(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        // Regex: # followed by exactly 6 hex characters
        string pattern = "^#[0-9A-Fa-f]{6}$";

        return Regex.IsMatch(input, pattern);
    }

    static void Main(string[] args)
    {
        // Example input
        string input = "#FF5733";

        bool result = IsValidHexColor(input);

        Console.WriteLine(result);
    }
}
