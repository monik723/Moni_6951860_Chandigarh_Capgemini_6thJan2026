// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the string: ");
    string? s = Console.ReadLine();
    if (s == null)
    {
      Console.WriteLine("Invalid input.");
      return;
    }

    int deletions = DeleteConsecutiveVowels(s);
    Console.WriteLine("Deletions: " + deletions);
  }

  static int DeleteConsecutiveVowels(string s)
  {
    int count = 0;
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < s.Length; i++)
    {
      if (i + 1 < s.Length && IsVowel(s[i]) && IsVowel(s[i + 1]))
      {
        count++;
        i++; // skip next
      }
      else
      {
        sb.Append(s[i]);
      }
    }
    return count;
  }

  static bool IsVowel(char c)
  {
    c = char.ToLower(c);
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
  }
}
