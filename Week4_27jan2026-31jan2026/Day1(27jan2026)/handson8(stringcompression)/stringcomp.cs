using System;

class Program
{
    static string CompressString(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        string result = "";
        int count = 1;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                count++; // same character, increase count
            }
            else
            {
                result += s[i] + count.ToString(); // append char + count
                count = 1; // reset count for next character
            }
        }

        // append the last character and its count
        result += s[s.Length - 1] + count.ToString();

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        string compressed = CompressString(input);
        Console.WriteLine(compressed);
    }
}
