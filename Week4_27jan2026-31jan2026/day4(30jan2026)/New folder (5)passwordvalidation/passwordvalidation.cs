using System;

class UserProgramCode
{
    public static int ValidatePassword(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 8)
            return -1;

        // Should not start with digit or special character
        if (!char.IsLetter(input[0]))
            return -1;

        // Should not end with special character
        char lastChar = input[input.Length - 1];
        if (!char.IsLetterOrDigit(lastChar))
            return -1;

        bool hasLetter = false;
        bool hasDigit = false;
        bool hasRequiredSpecial = false;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
                hasLetter = true;
            else if (char.IsDigit(c))
                hasDigit = true;
            else if (c == '@' || c == '#' || c == '_')
                hasRequiredSpecial = true;
        }

        if (hasLetter && hasDigit && hasRequiredSpecial)
            return 1;

        return -1;
    }
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(UserProgramCode.ValidatePassword(input));
    }
}
