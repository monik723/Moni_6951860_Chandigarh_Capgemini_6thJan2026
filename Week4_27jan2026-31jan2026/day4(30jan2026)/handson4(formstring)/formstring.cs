using System;

class UserProgramCode
{
    public static string formString(string[] input1, int input2)
    {
        string result = "";

        foreach (string str in input1)
        {
            // Check for special characters
            foreach (char ch in str)
            {
                if (!char.IsLetter(ch))
                {
                    return "-1";
                }
            }

            // Pick nth character or $
            if (str.Length >= input2)
            {
                result += str[input2 - 1];
            }
            else
            {
                result += "$";
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        int k = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[k];

        for (int i = 0; i < k; i++)
        {
            arr[i] = Console.ReadLine();
        }

        int n = Convert.ToInt32(Console.ReadLine());

        string output = UserProgramCode.formString(arr, n);
        Console.WriteLine(output);
    }
}