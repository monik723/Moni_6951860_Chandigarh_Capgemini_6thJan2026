using System;

class Solution
{
    public static int CountTriplets(int[] arr, int d)
    {
        int n = arr.Length;
        int count = 0;

        // Fix middle element j
        for (int j = 1; j < n - 1; j++)
        {
            int[] freq = new int[d];

            // Count remainders for i < j
            for (int i = 0; i < j; i++)
            {
                int rem = ((arr[i] % d) + d) % d;
                freq[rem]++;
            }

            // Check k > j
            for (int k = j + 1; k < n; k++)
            {
                int remJ = ((arr[j] % d) + d) % d;
                int remK = ((arr[k] % d) + d) % d;

                int required = (d - (remJ + remK) % d) % d;
                count += freq[required];
            }
        }

        return count;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int d = 3;

        Console.WriteLine(CountTriplets(arr, d));
    }
}
