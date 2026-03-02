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

    Console.Write("Enter the word to remove: ");
    string? word = Console.ReadLine();
    if (word == null)
    {
      Console.WriteLine("Invalid word.");
      return;
    }

    int index = input.LastIndexOf(word);
    if (index != -1)
    {
      input = input.Remove(index, word.Length);
    }

    Console.WriteLine("String after removing last occurrence of '" + word + "':");
    Console.WriteLine(input);
  }
}
