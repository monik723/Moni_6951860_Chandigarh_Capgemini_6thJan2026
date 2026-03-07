using System;

public class Program
{
    public string CleanseAndInvert(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return "";
        }

        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return "";
            }
        }

        input = input.ToLower();

        string filtered = "";
        foreach (char c in input)
        {
            if ((int)c % 2 != 0)
            {
                filtered += c;
            }
        }

        char[] arr = filtered.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        char[] result = reversed.ToCharArray();
        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = char.ToUpper(result[i]);
            }
        }

        return new string(result);
    }

    public static void Main()
    {
        Program p = new Program();

        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();

        string output = p.CleanseAndInvert(input);

        if (output == "")
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("The generated key is - " + output);
        }
    }
}