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
    int[] arr = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
      if (!int.TryParse(parts[i], out arr[i]))
      {
        Console.WriteLine("Invalid array element.");
        return;
      }
    }

    Array.Reverse(arr);

    Console.WriteLine("Reversed array: " + string.Join(" ", arr));
  }
}
