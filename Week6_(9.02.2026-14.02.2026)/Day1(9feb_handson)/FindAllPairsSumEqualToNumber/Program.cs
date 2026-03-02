// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter array elements separated by spaces: ");
    string? input = Console.ReadLine();
    if (input == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] arr = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
      if (!int.TryParse(parts[i], out arr[i]))
      {
        Console.WriteLine("Invalid array element.");
        return;
      }
    }

    Console.Write("Enter the target sum: ");
    string? sumInput = Console.ReadLine();
    if (sumInput == null || !int.TryParse(sumInput, out int target))
    {
      Console.WriteLine("Invalid target sum.");
      return;
    }

    List<string> pairs = new List<string>();
    for (int i = 0; i < arr.Length; i++)
    {
      for (int j = i + 1; j < arr.Length; j++)
      {
        if (arr[i] + arr[j] == target)
        {
          pairs.Add($"({arr[i]}, {arr[j]})");
        }
      }
    }

    if (pairs.Count == 0)
    {
      Console.WriteLine("No pairs found.");
    }
    else
    {
      Console.WriteLine("Pairs: " + string.Join(", ", pairs));
    }
  }
}
