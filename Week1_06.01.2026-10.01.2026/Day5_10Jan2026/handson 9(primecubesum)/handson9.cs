using System;

class Program
{
    static void Main()
    {
        int input1 = 7;

        PrimeCubeSum obj = new PrimeCubeSum();
        int result = obj.SumOfPrimeCubes(input1);

        Console.WriteLine("Output = " + result);
    }
}

class PrimeCubeSum
{
    public int SumOfPrimeCubes(int n)
    {
        
        if (n < 0 || n > 7)
        {
            return -1;
        }

        int sum = 0;

        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                sum += i * i * i;  
            }
        }

        return sum;
    }

    
    private bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
