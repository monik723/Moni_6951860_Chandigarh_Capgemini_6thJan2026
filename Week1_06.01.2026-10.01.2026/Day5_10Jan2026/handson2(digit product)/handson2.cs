using System;

class Program
{
    static void Main()
    {
        int input1 = 56;

        DigitProduct obj = new DigitProduct();
        int result = obj.CheckProduct(input1);

        Console.WriteLine("Output = " + result);
    }
}

class DigitProduct
{
    public int CheckProduct(int input1)
    {
        
        if (input1 < 0)
        {
            return -1;
        }

     
        if (input1 % 3 == 0 || input1 % 5 == 0)
        {
            return -2;
        }

        int product = 1;
        int temp = input1;

       
        while (temp > 0)
        {
            int digit = temp % 10;
            product = product * digit;
            temp = temp / 10;
        }

       
        if (product % 3 == 0 || product % 5 == 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
