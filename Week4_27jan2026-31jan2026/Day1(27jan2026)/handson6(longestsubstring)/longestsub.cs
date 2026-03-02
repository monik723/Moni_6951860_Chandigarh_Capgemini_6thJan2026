using System;

class Program
{
    static int LongestSubstring(string s)
    {
        int n = s.Length;
        int maxLen = 0;

        for (int i = 0; i < n; i++)
        {
            bool[] isRepeat = new bool[256]; // ASCII characters
            int currentLen = 0;

            for (int j = i; j < n; j++)
            {
                if (isRepeat[s[j]])
                {
                    // Repeated character found, break
                    break;
                }
                else
                {
                    isRepeat[s[j]] = true; // mark character as seen
                    currentLen++;
                }
            }

            if (currentLen > maxLen)
                maxLen = currentLen;
        }

        return maxLen;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        int result = LongestSubstring(s);
        Console.WriteLine(result);
    }
}
