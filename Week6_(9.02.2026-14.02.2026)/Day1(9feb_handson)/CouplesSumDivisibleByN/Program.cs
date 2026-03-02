using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter N: ");
    string? nInput = Console.ReadLine();
    if (nInput == null || !int.TryParse(nInput, out int N) || N <= 0)
    {
      Console.WriteLine("Invalid N.");
      return;
    }

    Console.Write("Enter array elements separated by spaces: ");
    string? arrInput = Console.ReadLine();
    if (arrInput == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    string[] parts = arrInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] arr = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
      if (!int.TryParse(parts[i], out arr[i]))
      {
        Console.WriteLine("Invalid array element.");
        return;
      }
    }

    int count = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
      if ((arr[i] + arr[i + 1]) % N == 0)
      {
        count++;
      }
    }

    Console.WriteLine("Number of couples: " + count);
  }
}
