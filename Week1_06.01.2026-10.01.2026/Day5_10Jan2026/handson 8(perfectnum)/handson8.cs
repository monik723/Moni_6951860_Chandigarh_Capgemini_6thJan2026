using System;

class Program
{
    static void Main()
    {
        int input1 = 6;

        PerfectNumberChecker obj = new PerfectNumberChecker();
        int result = obj.CheckPerfect(input1);

        Console.WriteLine("Output = " + result);
    }
}

class PerfectNumberChecker
{
    public int CheckPerfect(int input1)
    {
        
        if (input1 < 0)
        {
            return -2;
        }

        int sum = 0;

      
        for (int i = 1; i <= input1 / 2; i++)
        {
            if (input1 % i == 0)
            {
                sum += i;
            }
        }

       
        if (sum == input1 && input1 != 0)
        {
            return 1;
        }
        else
        {
            
            return -1;
        }
    }
}
