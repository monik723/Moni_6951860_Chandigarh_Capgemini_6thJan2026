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

    Console.Write("Enter the character to replace: ");
    string? charInput = Console.ReadLine();
    if (charInput == null || charInput.Length != 1)
    {
      Console.WriteLine("Invalid character.");
      return;
    }
    char toReplace = charInput[0];

    Console.Write("Enter the character to replace with: ");
    string? replaceWithInput = Console.ReadLine();
    if (replaceWithInput == null || replaceWithInput.Length != 1)
    {
      Console.WriteLine("Invalid character.");
      return;
    }
    char replaceWith = replaceWithInput[0];

    int index = input.IndexOf(toReplace);
    if (index != -1)
    {
      char[] chars = input.ToCharArray();
      chars[index] = replaceWith;
      input = new string(chars);
    }

    Console.WriteLine("String after replacing '" + toReplace + "' with '" + replaceWith + "': " + input);
  }
}
