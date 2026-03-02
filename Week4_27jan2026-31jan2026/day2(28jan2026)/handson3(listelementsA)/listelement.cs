using System;
using System.Collections.Generic;

class UserProgramCode
{
    public static List<int> GetElements(List<int> input1, int input2)
    {
        List<int> result = new List<int>();

        // Collect elements smaller than input2
        foreach (int x in input1)
        {
            if (x < input2)
            {
                result.Add(x);
            }
        }

        // If no element found, return list with -1
        if (result.Count == 0)
        {
            result.Add(-1);
            return result;
        }

        // Sort in descending order
        result.Sort();
        result.Reverse();

        return result;
    }
}

class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> input1 = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int val = int.Parse(Console.ReadLine());
            input1.Add(val);
        }

        int input2 = int.Parse(Console.ReadLine());

        List<int> output = UserProgramCode.GetElements(input1, input2);

        if (output.Count == 1 && output[0] == -1)
        {
            Console.WriteLine("No element found");
        }
        else
        {
            foreach (int x in output)
            {
                Console.Write(x + " ");
            }
        }
    }
}
