using System;

class Program
{
    static void Main()
    {
        int input1 = 98;

        TemperatureConverter obj = new TemperatureConverter();
        int result = obj.FahrenheitToCelsius(input1);

        Console.WriteLine("Output = " + result);
    }
}

class TemperatureConverter
{
    public int FahrenheitToCelsius(int input1)
    {
       
        if (input1 < 0)
        {
            return -1;
        }

        int celsius = (input1 - 32) * 5 / 9;

        return celsius;
    }
}
