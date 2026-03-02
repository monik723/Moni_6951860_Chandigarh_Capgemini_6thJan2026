using System;

class Program
{
    static void Main()
    {
        int[] input1 = { 21, 23, 41, 4 };
        int[] input2 = { 3, 4, 1, 5 };
        int input3 = 4;

        ArrayAdder obj = new ArrayAdder();
        int[] result = obj.AddArrays(input1, input2, input3);

        Console.WriteLine("Output:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}

class ArrayAdder
{
    public int[] AddArrays(int[] input1, int[] input2, int input3)
    {
        int[] output = new int[input3];

        
        if (input3 < 0)
        {
            output = new int[1];
            output[0] = -2;
            return output;
        }

       
        for (int i = 0; i < input3; i++)
        {
            if (input1[i] < 0 || input2[i] < 0)
            {
                output[0] = -1;
                return output;
            }
        }

        
        for (int i = 0; i < input3; i++)
        {
            output[i] = input1[i] + input2[input3 - 1 - i];
        }

        return output;
    }
}
