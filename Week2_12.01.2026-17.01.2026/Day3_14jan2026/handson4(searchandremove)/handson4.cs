using System;

class RemoveAndSort
{
    public int[] GetResult(int[] input1, int input2, int input3)
    {
       
        if (input2 < 0)
        {
            return new int[] { -2 };
        }

        
        for (int i = 0; i < input2; i++)
        {
            if (input1[i] < 0)
            {
                return new int[] { -1 };
            }
        }

        
        int index = -1;
        for (int i = 0; i < input2; i++)
        {
            if (input1[i] == input3)
            {
                index = i;
                break;
            }
        }

        // Rule 3: If search element not found
        if (index == -1)
        {
            return new int[] { -3 };
        }

        
        int[] result = new int[input2 - 1];
        int j = 0;

        for (int i = 0; i < input2; i++)
        {
            if (i != index)
            {
                result[j] = input1[i];
                j++;
            }
        }

        
        for (int i = 0; i < result.Length - 1; i++)
        {
            for (int k = 0; k < result.Length - 1 - i; k++)
            {
                if (result[k] > result[k + 1])
                {
                    int temp = result[k];
                    result[k] = result[k + 1];
                    result[k + 1] = temp;
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
        RemoveAndSort obj = new RemoveAndSort();

        int[] input1 = { 54, 26, 78, 32, 55 };
        int input2 = 5;
        int input3 = 78;

        int[] output = obj.GetResult(input1, input2, input3);

        Console.WriteLine("Output:");

        for (int i = 0; i < output.Length; i++)
        {
            Console.Write(output[i] + " ");
        }

        Console.ReadLine();
    }
}
