using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter a positive integer: ");
    string? input = Console.ReadLine();
    if (input == null || !long.TryParse(input, out long number) || number <= 0)
    {
      Console.WriteLine("Invalid input. Please enter a positive integer.");
      return;
    }

    int sum = 0;
    foreach (char c in input)
    {
      if (char.IsDigit(c))
      {
        sum += c - '0';
      }
    }

    Console.WriteLine("Sum of digits: " + sum);
  }
}
