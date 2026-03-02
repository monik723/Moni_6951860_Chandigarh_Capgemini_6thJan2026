using System;

class Solution
{
    public static int CountValidWords(string[] words)
    {
        int validCount = 0;

        foreach (string word in words)
        {
            if (IsValidWord(word))
            {
                validCount++;
            }
        }

        return validCount;
    }

    private static bool IsValidWord(string word)
    {
        // Condition 1: Length > 2
        if (word.Length <= 2)
            return false;

        bool hasVowel = false;
        bool hasConsonant = false;

        foreach (char ch in word)
        {
            // Condition 4: Only letters or digits allowed
            if (!char.IsLetterOrDigit(ch))
                return false;

            if (char.IsLetter(ch))
            {
                char lower = char.ToLower(ch);

                if ("aeiou".Contains(lower))
                    hasVowel = true;
                else
                    hasConsonant = true;
            }
        }

        // Condition 2 & 3
        return hasVowel && hasConsonant;
    }

    static void Main()
    {
        string[] words = { "abc", "a1b", "ab", "123", "ab@c", "hello1" };

        int result = CountValidWords(words);
        Console.WriteLine("Number of valid words: " + result);
    }
}
