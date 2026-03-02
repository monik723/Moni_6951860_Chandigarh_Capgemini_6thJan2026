using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input1 = "12/02/2014";
        string input2 = "27/02/2014";

        // Convert string to DateTime using exact format
        DateTime date1 = DateTime.ParseExact(input1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime date2 = DateTime.ParseExact(input2, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        // Calculate difference
        TimeSpan difference = date2 - date1;

        Console.WriteLine(difference.Days + " days");
    }
}
