using System;

class SumOfCubesOfPrimes
{
    public int Calculate(int n)
    {
        // Business Rule 1
        if (n < 0)
        {
            return -1;
        }

        // Business Rule 2
        if (n > 32676)
        {
            return -2;
        }

        int sum = 0;

        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                sum += i * i * i; // cube
            }
        }

        return sum;
    }

    // Method to check prime
    private bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i * i <= num; i++)
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
        Console.Write("Enter N value: ");
        int n = Convert.ToInt32(Console.ReadLine());

        SumOfCubesOfPrimes obj = new SumOfCubesOfPrimes();
        int result = obj.Calculate(n);

        Console.WriteLine("Output = " + result);
    }
}
