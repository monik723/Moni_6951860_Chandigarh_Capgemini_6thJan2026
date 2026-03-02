using System;

namespace Day3_08Jan2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number or character : ");
            string input = Console.ReadLine()!;

            if (input.Length == 1)
            {
                char ch = input[0];
                if (char.IsDigit(ch) && ch <= '9' && ch >= '0')
                {
                    int num = ch - '0';
                    Console.WriteLine("Your number is : " + num);
                }
                else if (char.IsLetter(ch))
                {
                    Console.WriteLine("Your character is : " + ch);
                    if (char.IsUpper(ch))
                    {
                        Console.WriteLine("It is an uppercase letter.");
                    }
                    else if (char.IsLower(ch))
                    {
                        Console.WriteLine("It is a lowercase letter.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else
            {
                Console.WriteLine("Please enter a single character or digit.");
            }

            Console.ReadLine();
        }
    }
}