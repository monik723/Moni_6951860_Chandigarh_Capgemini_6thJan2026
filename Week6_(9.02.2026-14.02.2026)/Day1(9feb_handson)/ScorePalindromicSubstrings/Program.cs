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

    int score = 0;
    for (int i = 0; i <= input.Length - 4; i++)
    {
      if (IsPalindrome(input, i, 4))
      {
        score += 5;
      }
    }
    for (int i = 0; i <= input.Length - 5; i++)
    {
      if (IsPalindrome(input, i, 5))
      {
        score += 10;
      }
    }

    Console.WriteLine("Score: " + score);
  }

  static bool IsPalindrome(string s, int start, int len)
  {
    for (int i = 0; i < len / 2; i++)
    {
      if (s[start + i] != s[start + len - 1 - i])
      {
        return false;
      }
    }
    return true;
  }
}
