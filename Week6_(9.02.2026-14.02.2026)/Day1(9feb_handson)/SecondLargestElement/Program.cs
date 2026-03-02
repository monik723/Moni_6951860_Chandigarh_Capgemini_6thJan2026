using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter array elements separated by spaces: ");
    string? input = Console.ReadLine();
    if (input == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (parts.Length < 2)
    {
      Console.WriteLine("Array must have at least 2 elements.");
      return;
    }

    int[] arr = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
      if (!int.TryParse(parts[i], out arr[i]))
      {
        Console.WriteLine("Invalid array element.");
        return;
      }
    }

    int max = int.MinValue;
    int secondMax = int.MinValue;
    foreach (int num in arr)
    {
      if (num > max)
      {
        secondMax = max;
        max = num;
      }
      else if (num > secondMax && num != max)
      {
        secondMax = num;
      }
    }

    if (secondMax == int.MinValue)
    {
      Console.WriteLine("No second largest element.");
    }
    else
    {
      Console.WriteLine("Second largest element: " + secondMax);
    }
  }
}
