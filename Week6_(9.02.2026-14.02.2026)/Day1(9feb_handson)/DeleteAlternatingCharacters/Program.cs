using System;
using System.Text;

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

    StringBuilder result = new StringBuilder();
    for (int i = 0; i < input.Length; i++)
    {
      if (i % 2 == 0)
      {
        result.Append(input[i]);
      }
    }

    Console.WriteLine("Result: " + result.ToString());
  }
}
