using System;
using System.Collections.Generic;

class UserProgramCode
{
    public static int getDonation(string[] input1, int input2)
    {
        // Rule 1: Check duplicates
        HashSet<string> set = new HashSet<string>();
        foreach (string s in input1)
        {
            if (!set.Add(s))
            {
                return -1; // duplicate found
            }
        }

        // Rule 2: Check for special characters
        foreach (string s in input1)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return -2; // special character found
                }
            }
        }

        int sum = 0;

        foreach (string s in input1)
        {
            // ABC DEF GHI
            // 012 345 678
            string locationCode = s.Substring(3, 3); // DEF
            string donationStr = s.Substring(6, 3);  // GHI

            int location = int.Parse(locationCode);
            int donation = int.Parse(donationStr);

            if (location == input2)
            {
                sum += donation;
            }
        }

        return sum;
    }
}

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input1 = new string[n];

        for (int i = 0; i < n; i++)
        {
            input1[i] = Console.ReadLine();
        }

        int input2 = int.Parse(Console.ReadLine());

        int result = UserProgramCode.getDonation(input1, input2);
        Console.WriteLine(result);
    }
}
