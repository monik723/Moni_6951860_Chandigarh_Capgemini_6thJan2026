// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter words separated by commas: ");
    string? input = Console.ReadLine();
    if (input == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] words = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
                          .Select(w => w.Trim().ToLower())
                          .ToArray();

    Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
    foreach (string word in words)
    {
      string key = SortString(word);
      if (!groups.ContainsKey(key))
      {
        groups[key] = new List<string>();
      }
      groups[key].Add(word);
    }

    List<string> unique = new List<string>();
    foreach (var group in groups.Values)
    {
      if (group.Count == 1)
      {
        unique.AddRange(group);
      }
    }

    unique.Sort();
    Console.WriteLine("[" + string.Join(", ", unique.Select(w => "\"" + w + "\"")) + "]");
  }

  static string SortString(string s)
  {
    return new string(s.OrderBy(c => c).ToArray());
  }
}
