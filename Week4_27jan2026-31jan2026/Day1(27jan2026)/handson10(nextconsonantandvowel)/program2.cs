using System;

class UserProgramCode
{
    public static string nextString(string input1)
    {
        string vowels = "aeiou";
        string result = "";

        foreach (char ch in input1)
        {
            // Rule 1: If not a letter, return Invalid input
            if (!char.IsLetter(ch))
                return "Invalid input";

            bool isUpper = char.IsUpper(ch);
            char c = char.ToLower(ch);

            // If vowel → next consonant
            if (vowels.Contains(c.ToString()))
            {
                char next = (char)(c + 1);

                // Just in case next is also vowel, skip it
                while (vowels.Contains(next.ToString()))
                {
                    next = (char)(next + 1);
                }

                if (isUpper)
                    next = char.ToUpper(next);

                result += next;
            }
            else // consonant → next vowel
            {
                char nextVowel = 'a';

                foreach (char v in vowels)
                {
                    if (v > c)
                    {
                        nextVowel = v;
                        break;
                    }
                }

                if (isUpper)
                    nextVowel = char.ToUpper(nextVowel);

                result += nextVowel;
            }
        }

        return result;
    }
}

class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string output = UserProgramCode.nextString(input);
        Console.WriteLine(output);
    }
}
