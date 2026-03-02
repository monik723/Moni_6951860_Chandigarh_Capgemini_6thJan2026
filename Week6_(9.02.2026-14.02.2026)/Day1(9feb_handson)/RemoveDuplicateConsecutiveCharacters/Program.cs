using System;
using System.Collections.Generic;

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

    Stack<char> stack = new Stack<char>();
    foreach (char c in input)
    {
      if (stack.Count > 0 && stack.Peek() == c)
      {
        stack.Pop();
      }
      else
      {
        stack.Push(c);
      }
    }

    char[] result = stack.ToArray();
    Array.Reverse(result);
    Console.WriteLine("Result: " + new string(result));
  }
}
