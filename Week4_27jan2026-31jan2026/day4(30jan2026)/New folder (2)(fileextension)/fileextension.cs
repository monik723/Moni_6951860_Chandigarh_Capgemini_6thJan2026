using System;

class UserProgramCode
{
    public static string ExtractExtension(string input)
    {
        // Check null or empty
        if (string.IsNullOrEmpty(input))
            return "-1";

        int index = input.LastIndexOf('.');

        // No dot OR dot at start/end
        if (index <= 0 || index == input.Length - 1)
            return "-1";

        return input.Substring(index + 1);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter file name:");
        string input = Console.ReadLine();

        string extension = UserProgramCode.ExtractExtension(input);

        if (extension == "-1")
            Console.WriteLine("Invalid file name or no extension found.");
        else
            Console.WriteLine("File extension: " + extension);
    }
}
