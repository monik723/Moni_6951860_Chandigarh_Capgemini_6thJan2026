using System;
using System.Collections.Generic;

class UserProgramCode
{
    public static int largestNumber(int[] input1)
    {
        bool hasNegative = false;
        bool hasInvalid = false;

        // Step 1: Check business rules
        foreach (int num in input1)
        {
            if (num < 0)
                hasNegative = true;
            if (num == 0 || num > 100)
                hasInvalid = true;
        }

        if (hasNegative && hasInvalid)
            return -3;
        if (hasNegative)
            return -1;
        if (hasInvalid)
            return -2;

        // Step 2: Remove duplicates
        HashSet<int> unique = new HashSet<int>(input1);

        // Step 3: Array to store max of each range (10 ranges)
        int[] maxInRange = new int[10];

        foreach (int num in unique)
        {
            int index = (num - 1) / 10;   // 1-10 -> 0, 11-20 -> 1, etc.

            if (num > maxInRange[index])
                maxInRange[index] = num;
        }

        // Step 4: Sum all maximums
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += maxInRange[i];
        }

        return sum;
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

        int result = UserProgramCode.largestNumber(arr);
        Console.WriteLine(result);
    }
}
