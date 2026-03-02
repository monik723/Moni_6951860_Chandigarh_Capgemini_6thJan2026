using System;

class SumOfCubesOfPrimes
{
    public int Calculate(int input1)
    {
       
        if (input1 < 0)
        {
            return -1;
        }

      
        if (input1 > 32767)
        {
            return -2;
        }

        int sum = 0;

        for (int i = 2; i <= input1; i++)
        {
            if (IsPrime(i))
            {
                sum = sum + (i * i * i);  // cube
            }
        }

        return sum;
    }

    private bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the limit: ");
        int n = Convert.ToInt32(Console.ReadLine());

        SumOfCubesOfPrimes obj = new SumOfCubesOfPrimes();
        int result = obj.Calculate(n);

        Console.WriteLine("Output: " + result);
    }
}
