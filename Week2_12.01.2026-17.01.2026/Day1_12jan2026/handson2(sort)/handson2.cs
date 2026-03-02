using System;

class RemoveNegativeAndSort
{
    public int[] ProcessArray(int[] arr, int size)
    {
        if (size < 0)
        {
            return new int[] { -1 };
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
                result[index++] = arr[i];
            }
        }

        
        for(int i = 0; i< count -1; i++)
        {
            for(int j = i+1; j<count; j++)
            {
                if(result[i]> result[j])
                {
                    int  temp  = result[j];
                    result[j] = result[i];
                    result[i] = temp;
                }   
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        if (size < 0)
        {
            Console.WriteLine("Output = -1");
            return;
        }

        int[] arr = new int[size];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        RemoveNegativeAndSort obj = new RemoveNegativeAndSort();
        int[] output = obj.ProcessArray(arr, size);

        if (output.Length == 1 && output[0] == -1)
        {
            Console.WriteLine("Output = -1");
        }
        else
        {
            Console.Write("Output: { ");
            foreach (int x in output)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }
    }
}
