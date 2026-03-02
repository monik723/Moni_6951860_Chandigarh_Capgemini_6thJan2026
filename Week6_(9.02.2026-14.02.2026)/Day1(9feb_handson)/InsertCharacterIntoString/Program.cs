using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the string: ");
    string? inputString = Console.ReadLine();
    if (inputString == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    Console.Write("Enter the character to insert: ");
    char character = Console.ReadKey().KeyChar;
    Console.WriteLine();

    Console.Write("Enter the position to insert at (0-based): ");
    string? positionInput = Console.ReadLine();
    if (positionInput == null || !int.TryParse(positionInput, out int position))
    {
      Console.WriteLine("Invalid position.");
      return;
    }

    if (position < 0 || position > inputString.Length)
    {
      Console.WriteLine("Invalid position.");
      return;
    }

    string result = inputString.Insert(position, character.ToString());
    Console.WriteLine("Result: " + result);
  }
}
