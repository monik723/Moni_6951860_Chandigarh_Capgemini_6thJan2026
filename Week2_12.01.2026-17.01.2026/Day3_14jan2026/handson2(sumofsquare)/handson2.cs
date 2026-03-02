using System;

class SumOfSquaresOfOddDigits
{
    public int Calculate(int input1)
    {
       
        if (input1 < 0)
        {
            return -1;
        }

        int num = input1;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;

           
            if (digit % 2 != 0)
            {
                sum = sum + (digit * digit);
            }

            num = num / 10;
        }

        return sum;
    }
}

class Program
{
    static void Main()
    {
        SumOfSquaresOfOddDigits obj = new SumOfSquaresOfOddDigits();

        int input1 = 12345;

        int output = obj.Calculate(input1);

        Console.WriteLine("Output = " + output);

        Console.ReadLine();
    }
}
