using System;
using System.Text;

namespace MahirlAssignment
{
    class UserMainCode
    {
        public static string ProcessString(string w1, string w2)
        {
            // Step 1: Remove common consonants from first word
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < w1.Length; i++)
            {
                char c = w1[i];
                char lower = Char.ToLower(c);

                // Check if consonant
                if (!IsVowel(lower))
                {
                    // If this consonant exists in word2 → skip it
                    if (ContainsIgnoreCase(w2, lower))
                    {
                        continue;
                    }
                }

                // Otherwise keep the character
                temp.Append(c);
            }

            // Step 2: Remove consecutive duplicate characters
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < temp.Length; i++)
            {
                if (i == 0)
                {
                    result.Append(temp[i]);
                }
                else
                {
                    if (Char.ToLower(temp[i]) != Char.ToLower(temp[i - 1]))
                    {
                        result.Append(temp[i]);
                    }
                }
            }

            return result.ToString();
        }

        public static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }

        public static bool ContainsIgnoreCase(string s, char ch)
        {
            char target = Char.ToLower(ch);

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.ToLower(s[i]) == target)
                    return true;
            }

            return false;
        }
    }
}
