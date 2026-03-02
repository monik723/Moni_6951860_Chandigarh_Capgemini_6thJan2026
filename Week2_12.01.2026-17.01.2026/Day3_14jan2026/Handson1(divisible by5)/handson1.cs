using System;

class AverageDivisibleBy5
{
    public int Calculate(int input1)
    {
        
        if (input1 < 0)
        {
            return -1;
        }

        int sum = 0;
        int count = 0;

        for (int i = 1; i <= input1; i++)
        {
            if (i % 5 == 0)
            {
                sum = sum + i;
                count++;
            }
        }

       
        if (count == 0)
        {
            return 0;
        }

        int average = sum / count; 

        return average;
    }
}

class Program
{
    static void Main()
    {
        AverageDivisibleBy5 obj = new AverageDivisibleBy5();

        int input1 = 20;

        int output = obj.Calculate(input1);

        Console.WriteLine("Output = " + output);

        Console.ReadLine();
    }
}
