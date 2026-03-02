// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter pipe separated words: ");
    string? input = Console.ReadLine();
    if (input == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] words = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
    Array.Reverse(words);
    string result = string.Join("|", words);
    Console.WriteLine("Reversed: " + result);
  }
}
