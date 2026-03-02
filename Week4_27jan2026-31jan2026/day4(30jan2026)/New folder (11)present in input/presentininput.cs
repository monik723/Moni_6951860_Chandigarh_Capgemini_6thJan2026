using System;

class UserProgramCode
{
    public static int CheckOrder(string input1, string input2, string input3)
    {
        if (string.IsNullOrEmpty(input1) ||
            string.IsNullOrEmpty(input2) ||
            string.IsNullOrEmpty(input3))
            return -1;

        int index2 = input1.IndexOf(input2);
        int index3 = input1.IndexOf(input3);

        if (index2 == -1 || index3 == -1)
            return -1;

        if (index3 > index2)
            return 1;

        return -1;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the main string:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the first substring:");
        string input2 = Console.ReadLine();

        Console.WriteLine("Enter the second substring:");
        string input3 = Console.ReadLine();

        int result = UserProgramCode.CheckOrder(input1, input2, input3);

        if (result == 1)
            Console.WriteLine("The second substring comes after the first substring.");
        else
            Console.WriteLine("Either substrings not found or order is incorrect.");
    }
}
