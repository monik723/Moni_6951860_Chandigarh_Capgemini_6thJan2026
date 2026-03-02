using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class UserProgramCode
{
    public static string[] getEmployee(string[] input1, string input2)
    {
        // Rule 1: Check for special characters
        Regex regex = new Regex("^[a-zA-Z ]+$");

        if (!regex.IsMatch(input2))
            return new string[] { "Invalid Input" };

        foreach (string s in input1)
        {
            if (!regex.IsMatch(s))
                return new string[] { "Invalid Input" };
        }

        List<string> employees = new List<string>();
        string designationToMatch = input2.ToLower();
        bool allSameDesignation = true;

        for (int i = 1; i < input1.Length; i += 2)
        {
            if (!input1[i].Equals(input1[1], StringComparison.OrdinalIgnoreCase))
                allSameDesignation = false;

            if (input1[i].Equals(designationToMatch, StringComparison.OrdinalIgnoreCase))
            {
                employees.Add(input1[i - 1]);
            }
        }

        // Rule 3: All employees belong to same designation
        if (allSameDesignation)
            return new string[] { "All employees belong to same " + input2 + " designation" };

        // Rule 2: No employee found
        if (employees.Count == 0)
            return new string[] { "No employee for " + input2 + " designation" };

        return employees.ToArray();
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input1 = new string[n];

        for (int i = 0; i < n; i++)
        {
            input1[i] = Console.ReadLine();
        }

        string input2 = Console.ReadLine();

        string[] result = UserProgramCode.getEmployee(input1, input2);

        foreach (string res in result)
        {
            Console.WriteLine(res);
        }
    }
}