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

    Dictionary<int, int> freq = new Dictionary<int, int>();
    foreach (int num in arr)
    {
      if (freq.ContainsKey(num))
      {
        freq[num]++;
      }
      else
      {
        freq[num] = 1;
      }
    }

    Console.WriteLine("Frequencies:");
    foreach (var pair in freq)
    {
      Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
  }
}
