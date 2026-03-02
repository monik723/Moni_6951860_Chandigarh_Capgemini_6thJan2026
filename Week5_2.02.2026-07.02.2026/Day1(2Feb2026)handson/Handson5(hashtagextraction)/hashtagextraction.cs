using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Read input text
        string input = Console.ReadLine();

        // Regex pattern to match hashtags
        string pattern = @"#\w+";

        // Find all hashtag matches
        MatchCollection matches = Regex.Matches(input, pattern);

        // Print each hashtag on a new line
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}