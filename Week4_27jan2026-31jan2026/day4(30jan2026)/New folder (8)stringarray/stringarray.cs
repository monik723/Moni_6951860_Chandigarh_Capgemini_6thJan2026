using System;
using System.Globalization;

class UserProgramCode
{
    public static int CheckOnlyNumeric(string[] input)
    {
        if (input == null || input.Length == 0)
            return -1;

        foreach (string s in input)
        {
            double num;
            if (!double.TryParse(s, NumberStyles.Any, 
                                 CultureInfo.InvariantCulture, out num))
            {
                return -1;
            }
        }

        return 1;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space:");
        string inputLine = Console.ReadLine();

        // Split input by space into string array
        string[] inputArray = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int result = UserProgramCode.CheckOnlyNumeric(inputArray);

        if (result == 1)
            Console.WriteLine("All inputs are numeric.");
        else
            Console.WriteLine("Input contains non-numeric values.");
    }
}
