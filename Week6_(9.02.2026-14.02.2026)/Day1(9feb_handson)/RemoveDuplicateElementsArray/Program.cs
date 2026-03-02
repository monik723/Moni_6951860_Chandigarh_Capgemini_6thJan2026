using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter array elements separated by commas: ");
    string? input = Console.ReadLine();
    if (input == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] parts = input.Split(',');
    List<int> array = new List<int>();
    foreach (string part in parts)
    {
      if (int.TryParse(part.Trim(), out int num))
      {
        array.Add(num);
      }
    }

    HashSet<int> unique = new HashSet<int>(array);
    int[] result = unique.ToArray();

    Console.WriteLine("Array after removing duplicates: " + string.Join(", ", result));
  }
}
