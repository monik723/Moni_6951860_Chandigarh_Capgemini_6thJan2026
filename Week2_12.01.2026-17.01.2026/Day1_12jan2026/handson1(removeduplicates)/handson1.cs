using System;

class RemoveDuplicates
{
    public int[] RemoveRepeated(int[] arr, int size)
    {
       
        for (int i = 0; i < size; i++)
        {
            if (arr[i] < 0)
            {
                return new int[] { -1 };
            }
        }

        
        int[] temp = new int[size];
        int uniqueCount = 0;

        for (int i = 0; i < size; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < uniqueCount; j++)
            {
                if (arr[i] == temp[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                temp[uniqueCount] = arr[i];
                uniqueCount++;
            }
        }

       
        int[] result = new int[uniqueCount];
        for (int i = 0; i < uniqueCount; i++)
        {
            result[i] = temp[i];
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

        int[] arr = new int[size];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        RemoveDuplicates obj = new RemoveDuplicates();
        int[] output = obj.RemoveRepeated(arr, size);

        if (output.Length == 1 && output[0] == -1)
        {
            Console.WriteLine("Output = { -1 }");
        }
        else
        {
            Console.Write("Output = { ");
            foreach (int x in output)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("}");
        }
    }
}
