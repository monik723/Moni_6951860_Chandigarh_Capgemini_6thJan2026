using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Product Type (M/V/C/D): ");
        char product = Char.ToUpper(Console.ReadLine()[0]);

        Console.Write("Enter Product Price: ");
        int price = Convert.ToInt32(Console.ReadLine());

        double vatPercentage = 0;

        switch (product)
        {
            case 'M':
                vatPercentage = 5;
                break;

            case 'V':
                vatPercentage = 12;
                break;

            case 'C':
                vatPercentage = 6.25;
                break;

            case 'D':
                vatPercentage = 6;
                break;

            default:
                Console.WriteLine("Invalid Product Type");
                return;
        }

        double vatAmount = (price * vatPercentage) / 100;

        Console.WriteLine("VAT Percentage: " + vatPercentage + "%");
        Console.WriteLine("VAT Amount: " + vatAmount);
    }
}
