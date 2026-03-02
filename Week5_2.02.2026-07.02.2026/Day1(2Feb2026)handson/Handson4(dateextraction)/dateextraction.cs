using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Read input line
        string input = Console.ReadLine();

        // Regex pattern for dd/mm/yyyy
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

        // Find all matches
        MatchCollection matches = Regex.Matches(input, pattern);

        // Print each date on a new line
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}