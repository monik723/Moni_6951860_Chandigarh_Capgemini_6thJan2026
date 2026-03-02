using System;

class BinaryToDecimal
{
    public int Convert(int input1)
    {
        
        if (input1 > 11111)
        {
            return -2;
        }

        int num = input1;
        int decimalValue = 0;
        int baseValue = 1; 

        while (num > 0)
        {
            int lastDigit = num % 10;

           
            if (lastDigit != 0 && lastDigit != 1)
            {
                return -1;
            }

            decimalValue = decimalValue + (lastDigit * baseValue);
            baseValue = baseValue * 2;

            num = num / 10;
        }

        return decimalValue;
    }
}

class Program
{
    static void Main()
    {
        BinaryToDecimal obj = new BinaryToDecimal();

        int input1 = 1001;

        int output = obj.Convert(input1);

        Console.WriteLine("Output = " + output);

        Console.ReadLine();
    }
}
