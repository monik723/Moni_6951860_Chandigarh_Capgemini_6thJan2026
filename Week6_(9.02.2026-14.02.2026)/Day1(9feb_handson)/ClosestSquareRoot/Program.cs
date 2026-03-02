using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter a positive integer: ");
    string? input = Console.ReadLine();
    if (input == null || !long.TryParse(input, out long number) || number <= 0)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    long sqrt = (long)Math.Sqrt(number);
    long lower = sqrt * sqrt;
    long upper = (sqrt + 1) * (sqrt + 1);

    long diffLower = number - lower;
    long diffUpper = upper - number;

    long closest = diffLower <= diffUpper ? lower : upper;
    Console.WriteLine("Closest perfect square: " + closest);
  }
}
