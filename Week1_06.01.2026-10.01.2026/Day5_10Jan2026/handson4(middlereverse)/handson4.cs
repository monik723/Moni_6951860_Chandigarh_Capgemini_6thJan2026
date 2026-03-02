using System;

class Program
{
    static void Main()
    {
        int[] input1 = { 12, 34, 56, 17, 2 };
        int input2 = 5;

        ArrayReplace obj = new ArrayReplace();
        int[] result = obj.ReplaceArray(input1, input2);

        Console.WriteLine("Output:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}

class ArrayReplace
{
    public int[] ReplaceArray(int[] input1, int input2)
    {
        int[] output = new int[input2];

       
        if (input2 < 0)
        {
            output[0] = -2;
            return output;
        }

        if (input2 % 2 == 0)
        {
            output[0] = -3;
            return output;
        }

        
        for (int i = 0; i < input2; i++)
        {
            if (input1[i] < 0)
            {
                output[0] = -1;
                return output;
            }
        }

        
        for (int i = 0; i < input2; i++)
        {
            output[i] = input1[i];
        }

        
        int mid = input2 / 2;

        for (int i = 0; i < mid; i++)
        {
            int temp = output[i];
            output[i] = output[input2 - 1 - i];
            output[input2 - 1 - i] = temp;
        }

        return output;
    }
}
