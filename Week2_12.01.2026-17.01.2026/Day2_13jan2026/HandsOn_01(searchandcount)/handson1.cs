using System;

class CountSearchValue
{
    public int FindCount(int[] arr, int size, int search)
    {
       
        if (size < 0)
        {
            return -2;
        }

        
        if (search < 0)
        {
            return -3;
        }

        
        for (int i = 0; i < size; i++)
        {
            if (arr[i] < 0)
            {
                return -1;
            }
        }

       
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] == search)
            {
                count++;
            }
        }

        return count;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 3 };
        int size = 5;
        int search = 2;

        CountSearchValue obj = new CountSearchValue();
        int result = obj.FindCount(arr, size, search);

        Console.WriteLine("Output: " + result);
    }
}
