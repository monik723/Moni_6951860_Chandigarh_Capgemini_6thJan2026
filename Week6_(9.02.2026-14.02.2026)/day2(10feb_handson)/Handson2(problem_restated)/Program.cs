using System;

class Solution
{
    public static int LongestNonDecreasingSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        int currentBlocks = 0;

        // Traverse the string in blocks of size 2
        for (int i = 0; i + 1 < n; i += 2)
        {
            string block = s.Substring(i, 2);

            if (block == "10")
            {
                // "10" block breaks non-decreasing order
                maxLength = Math.Max(maxLength, currentBlocks * 2);
                currentBlocks = 0;
            }
            else
            {
                // Valid blocks: "00", "01", "11"
                currentBlocks++;
            }
        }

        // Final update
        maxLength = Math.Max(maxLength, currentBlocks * 2);

        return maxLength;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(LongestNonDecreasingSubstring(s));
    }
}
