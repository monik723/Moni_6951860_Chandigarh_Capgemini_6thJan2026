using System;

class Program
{
    static void Main()
    {
        int[] input1 = { 1, 2, 2, 3, 3 };
        int input2 = 5;

        RemoveDuplicates obj = new RemoveDuplicates();
        int[] result = obj.GetUniqueElements(input1, input2);

        Console.WriteLine("Output:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}

class RemoveDuplicates
{
    public int[] GetUniqueElements(int[] input1, int input2)
    {
       
        if (input2 < 0)
        {
            int[] output = new int[1];
            output[0] = -2;
            return output;
        }

       
        for (int i = 0; i < input2; i++)
        {
            if (input1[i] < 0)
            {
                int[] output = new int[1];
                output[0] = -1;
                return output;
            }
        }

        
        int[] temp = new int[input2];
        int uniqueCount = 0;

        for (int i = 0; i < input2; i++)
        {
            bool isDuplicate = false;

          
            for (int j = 0; j < uniqueCount; j++)
            {
                if (temp[j] == input1[i])
                {
                    isDuplicate = true;
                    break;
                }
            }

           
            if (!isDuplicate)
            {
                temp[uniqueCount] = input1[i];
                uniqueCount++;
            }
        }

        
        int[] outputArray = new int[uniqueCount];
        for (int i = 0; i < uniqueCount; i++)
        {
            outputArray[i] = temp[i];
        }

        return outputArray;
    }
}
