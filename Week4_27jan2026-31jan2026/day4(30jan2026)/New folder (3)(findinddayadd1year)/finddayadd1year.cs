using System;
using System.Globalization;

class UserProgramCode
{
    public static string FindDayAfterOneYear(string inputDate)
    {
        DateTime date;

        // Validate date format: dd/MM/yyyy
        bool isValid = DateTime.TryParseExact(
            inputDate,
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out date
        );

        // Invalid date format
        if (!isValid)
            return "-1";

        // Add 1 year
        DateTime newDate = date.AddYears(1);

        // Return day name
        return newDate.DayOfWeek.ToString();
    }

    static void Main(string[] args)
    {
        // Example input
        string inputDate = "14/02/2024";

        string result = FindDayAfterOneYear(inputDate);

        Console.WriteLine(result);
    }
}
