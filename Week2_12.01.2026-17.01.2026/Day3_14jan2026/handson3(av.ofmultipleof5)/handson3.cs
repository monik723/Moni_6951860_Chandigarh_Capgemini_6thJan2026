using System;

class AverageOfMultiplesOfFive
{
    public int Calculate(int input1)
    {
        
        if (input1 < 0)
        {
            return -1;
        }

        
        if (input1 > 500)
        {
            return -2;
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
        AverageOfMultiplesOfFive obj = new AverageOfMultiplesOfFive();

        int input1 = 15;

        int output = obj.Calculate(input1);

        Console.WriteLine("Output = " + output);

        Console.ReadLine();
    }
}
