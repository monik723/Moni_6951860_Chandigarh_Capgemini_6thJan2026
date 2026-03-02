using System;

class UserProgramCode
{
    public static int CountTripleConsecutiveChars(string input1)
    {
        if (string.IsNullOrEmpty(input1))
            return 0;

        int count = 0;
        int repeatCount = 1;

        for (int i = 1; i < input1.Length; i++)
        {
            if (input1[i] == input1[i - 1])
            {
                repeatCount++;

                // Count only once per group of 3
                if (repeatCount == 3)
                    count++;
            }
            else
            {
                repeatCount = 1;
            }
        }

        return count;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        int result = UserProgramCode.CountTripleConsecutiveChars(input);

        Console.WriteLine("Number of triple consecutive characters: " + result);
    }
}
