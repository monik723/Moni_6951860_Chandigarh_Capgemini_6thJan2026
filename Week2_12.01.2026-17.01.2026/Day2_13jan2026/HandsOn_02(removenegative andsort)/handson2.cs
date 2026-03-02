using System;

class RemoveNegativeAndSort
{
    public int[] ProcessArray(int[] arr, int size)
    {
       
        if (size < 0)
        {
            int[] error = new int[1];
            error[0] = -1;
            return error;
        }

      
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] >= 0)
            {
                count++;
            }
        }

        
        int[] result = new int[count];
        int index = 0;

        
        for (int i = 0; i < size; i++)
        {
            if (arr[i] >= 0)
            {
                result[index] = arr[i];
                index++;
            }
        }

        
        Array.Sort(result);

        return result;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 5, -2, 8, -1, 3, 0 };
        int size = 6;

        RemoveNegativeAndSort obj = new RemoveNegativeAndSort();
        int[] output = obj.ProcessArray(arr, size);

        Console.WriteLine("Output Array:");

        for (int i = 0; i < output.Length; i++)
        {
            Console.Write(output[i] + " ");
        }
    }
}
