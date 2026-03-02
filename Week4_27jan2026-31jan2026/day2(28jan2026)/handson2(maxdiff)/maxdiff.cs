using System;
using System.Collections.Generic;

class UserProgramCode
{
    public static int diffIntArray(int[] input1)
    {
        int n = input1.Length;

        // Rule 2: If only one element or more than 10 elements
        if (n == 1 || n > 10)
            return -2;

        // Rule 1: If any negative number exists
        foreach (int x in input1)
        {
            if (x < 0)
                return -1;
        }

        // Rule 3: Check duplicates
        HashSet<int> set = new HashSet<int>();
        foreach (int x in input1)
        {
            if (!set.Add(x))
                return -3;
        }

        // Find maximum difference (j > i)
        int minSoFar = input1[0];
        int maxDiff = 0;

        for (int i = 1; i < n; i++)
        {
            if (input1[i] - minSoFar > maxDiff)
            {
                maxDiff = input1[i] - minSoFar;
            }

            if (input1[i] < minSoFar)
            {
                minSoFar = input1[i];
            }
        }

        return maxDiff;
    }
}

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int result = UserProgramCode.diffIntArray(arr);
        Console.WriteLine(result);
    }
}
