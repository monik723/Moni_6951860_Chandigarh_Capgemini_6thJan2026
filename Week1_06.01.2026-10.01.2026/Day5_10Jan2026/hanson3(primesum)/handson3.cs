using System;

class Program
{
    static void Main()
    {
        int[] input1 = { 1, 2, 3, 4, 5 };
        int input2 = 5;

        PrimeSum obj = new PrimeSum();
        int result = obj.SumOfPrimes(input1, input2);

        Console.WriteLine("Output = " + result);
    }
}

class PrimeSum
{
    public int SumOfPrimes(int[] input1, int input2)
    {
        
        if (input2 < 0)
        {
            return -2;
        }

        
        for (int i = 0; i < input2; i++)
        {
            if (input1[i] < 0)
            {
                return -1;
            }
        }

        int sum = 0;
        bool foundPrime = false;

     
        for (int i = 0; i < input2; i++)
        {
            if (IsPrime(input1[i]))
            {
                sum += input1[i];
                foundPrime = true;
            }
        }

        
        if (!foundPrime)
        {
            return -3;
        }

        return sum;
    }

    
    private bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
