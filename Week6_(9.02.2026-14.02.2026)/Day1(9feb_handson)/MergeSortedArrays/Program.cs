using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter first sorted array elements separated by spaces: ");
    string? input1 = Console.ReadLine();
    if (input1 == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] parts1 = input1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    List<int> arr1 = new List<int>();
    foreach (string part in parts1)
    {
      if (int.TryParse(part, out int num))
      {
        arr1.Add(num);
      }
    }

    Console.Write("Enter second sorted array elements separated by spaces: ");
    string? input2 = Console.ReadLine();
    if (input2 == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] parts2 = input2.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    List<int> arr2 = new List<int>();
    foreach (string part in parts2)
    {
      if (int.TryParse(part, out int num))
      {
        arr2.Add(num);
      }
    }

    List<int> merged = new List<int>(arr1);
    merged.AddRange(arr2);
    merged.Sort();

    Console.WriteLine("Merged sorted array: " + string.Join(" ", merged));
  }
}
