using System;
using System.Collections.Generic;

class Program
{
    static string IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c); // push opening brackets
            }
            else // closing bracket
            {
                if (stack.Count == 0)
                    return "NO"; // nothing to match with

                char top = stack.Pop(); // get last opening bracket

                // check if it matches
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return "NO"; // mismatch
                }
            }
        }

        // after processing all characters
        if (stack.Count == 0)
            return "YES"; // all brackets matched
        else
            return "NO"; // some opening brackets didn't close
    }

    static void Main()
    {
        string input = Console.ReadLine();
        string result = IsValid(input);
        Console.WriteLine(result);
    }
}
