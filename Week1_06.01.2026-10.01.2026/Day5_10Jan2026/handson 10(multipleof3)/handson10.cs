using System;

class Program
{
    static void Main()
    {
        int[] input1 = { 1, 3, 6, 4, 9 };
        int input2 = 5;

        MultipleOfThreeCounter obj = new MultipleOfThreeCounter();
        int result = obj.CountMultiples(input1, input2);

        Console.WriteLine("Output = " + result);
    }
}

class MultipleOfThreeCounter
{
    public int CountMultiples(int[] input1, int input2)
    {
        
        for (int i = 0; i < input2; i++)
        {
            if (input1[i] < 0)
            {
                return -1;
            }
        }

        int count = 0;

        
        for (int i = 0; i < input2; i++)
        {
            if (input1[i] % 3 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
