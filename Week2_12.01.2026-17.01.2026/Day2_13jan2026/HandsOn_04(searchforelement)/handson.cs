using System;

class SearchElement
{
    public int Search(int[] arr, int size, int searchElement)
    {
        
        if (size < 0)
        {
            return -2;
        }

        
        for (int i = 0; i < size; i++)
        {
            if (arr[i] < 0)
            {
                return -1;
            }
        }

       
        for (int i = 0; i < size; i++)
        {
            if (arr[i] == searchElement)
            {
                return 1; 
            }
        }

       
        return -3;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int size = 5;
        int searchElement = 30;

        SearchElement obj = new SearchElement();
        int result = obj.Search(arr, size, searchElement);

        Console.WriteLine("Output: " + result);
    }
}
