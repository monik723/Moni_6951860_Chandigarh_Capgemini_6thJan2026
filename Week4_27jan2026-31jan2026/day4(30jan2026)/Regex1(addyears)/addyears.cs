using System;
using System.Globalization;

class UserProgramCode
{
    public static string AddYearsToDate(string inputDate, int years)
    {
        // Rule 2: years negative
        if (years < 0)
            return "-2";

        DateTime date;

        // Rule 1: invalid date format
        bool isValidDate = DateTime.TryParseExact(
            inputDate,
            "dd-MM-yyyy",   // expected format
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out date
        );

        if (!isValidDate)
            return "-1";

        // Add years
        DateTime newDate = date.AddYears(years);

        return newDate.ToString("dd-MM-yyyy");
    }
}

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)  // Run five times
        {
            Console.WriteLine($"Enter date #{i + 1} in dd-MM-yyyy format:");
            string inputDate = Console.ReadLine();

            Console.WriteLine("Enter number of years to add:");
            string yearsInput = Console.ReadLine();
            int years;

            if (!int.TryParse(yearsInput, out years))
            {
                Console.WriteLine("Invalid number of years. Skipping...");
                continue;
            }

            string result = UserProgramCode.AddYearsToDate(inputDate, years);

            if (result == "-1")
                Console.WriteLine("Invalid date format.");
            else if (result == "-2")
                Console.WriteLine("Number of years cannot be negative.");
            else
                Console.WriteLine("New date after adding years: " + result);

            Console.WriteLine(); // blank line for readability
        }
    }
}
