using System;

namespace LuckyString
{
    class UserMainCode
    {
        public static string CheckLuckyString(int n, string str)
        {
            // If substring length > string length → Invalid
            if (n > str.Length)
                return "Invalid";

            int needed = n / 2;

            // Slide window of size n
            for (int i = 0; i <= str.Length - n; i++)
            {
                string sub = str.Substring(i, n);

                // Check if substring contains only P, S, G
                bool validChars = true;
                for (int k = 0; k < sub.Length; k++)
                {
                    if (sub[k] != 'P' && sub[k] != 'S' && sub[k] != 'G')
                    {
                        validChars = false;
                        break;
                    }
                }

                if (!validChars)
                    continue;

                // Check for at least n/2 consecutive P or S or G
                if (HasConsecutive(sub, 'P', needed) ||
                    HasConsecutive(sub, 'S', needed) ||
                    HasConsecutive(sub, 'G', needed))
                {
                    return "Yes";
                }
            }

            return "No";
        }

        public static bool HasConsecutive(string s, char ch, int needed)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                {
                    count++;
                    if (count >= needed)
                        return true;
                }
                else
                {
                    count = 0;
                }
            }

            return false;
        }
    }
}
