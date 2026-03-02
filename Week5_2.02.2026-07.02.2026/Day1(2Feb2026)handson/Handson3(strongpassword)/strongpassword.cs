using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Read password input
        string password = Console.ReadLine();

        // Conditions
        bool lengthCheck = password.Length >= 8;
        bool upperCheck = Regex.IsMatch(password, "[A-Z]");
        bool lowerCheck = Regex.IsMatch(password, "[a-z]");
        bool digitCheck = Regex.IsMatch(password, "[0-9]");
        bool specialCheck = Regex.IsMatch(password, "[@$!%*?&]");

        // Final validation
        if (lengthCheck && upperCheck && lowerCheck && digitCheck && specialCheck)
            Console.WriteLine("Strong");
        else
            Console.WriteLine("Weak");
    }
}