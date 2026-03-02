// See https://aka.ms/new-console-template for more information
using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the string: ");
    string? input = Console.ReadLine();
    if (input == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    Console.Write("Enter the substring to insert: ");
    string? substring = Console.ReadLine();
    if (substring == null)
    {
      Console.WriteLine("Invalid substring.");
      return;
    }

    Console.Write("Enter the position: ");
    string? posInput = Console.ReadLine();
    if (!int.TryParse(posInput, out int position) || position < 0 || position > input.Length)
    {
      Console.WriteLine("Invalid position.");
      return;
    }

    string result = input.Insert(position, substring);
    Console.WriteLine("Result: " + result);
  }
}
