using System;

class HalfSortArray
{
    public int[] SortHalf(int[] arr, int n)
    {
        
        if (n < 0)
        {
            return new int[] { -1 };
        }

        int mid = n / 2;

        
        for (int i = 0; i < mid - 1; i++)
        {
            for (int j = i + 1; j < mid; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

       
        for (int i = mid; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        return arr;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 4, 2, 8, 6, 9, 3, 5 };
        int n = arr.Length;

        HalfSortArray obj = new HalfSortArray();
        int[] result = obj.SortHalf(arr, n);

        Console.WriteLine("Output Array:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
