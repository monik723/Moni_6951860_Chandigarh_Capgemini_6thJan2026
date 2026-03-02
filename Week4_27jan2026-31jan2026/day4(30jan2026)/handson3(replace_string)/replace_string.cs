using System;

class UserProgramCode
{
    public static string replaceString(string input1, int input2, char input3)
    {
        // Rule 1: Only alphabets and spaces allowed
        foreach (char c in input1)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                return "-1";
            }
        }

        // Rule 2: input2 must be positive
        if (input2 <= 0)
        {
            return "-2";
        }

        // Rule 3: input3 must be a special character
        if (char.IsLetterOrDigit(input3))
        {
            return "-3";
        }

        string[] words = input1.Split(' ');

        // If nth word exists, replace its characters
        if (input2 <= words.Length)
        {
            int len = words[input2 - 1].Length;
            words[input2 - 1] = new string(input3, len);
        }

        // Join and convert to lowercase
        return string.Join(" ", words).ToLower();
    }
}

class Program
{
    static void Main()
    {
        string input1 = Console.ReadLine();
        int input2 = int.Parse(Console.ReadLine());
        char input3 = char.Parse(Console.ReadLine());

        string result = UserProgramCode.replaceString(input1, input2, input3);

        if (result == "-1")
        {
            Console.WriteLine("Invalid String");
        }
        else if (result == "-2")
        {
            Console.WriteLine("Number not positive");
        }
        else if (result == "-3")
        {
            Console.WriteLine("Character not a special character");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}