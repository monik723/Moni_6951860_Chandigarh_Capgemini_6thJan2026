using System;
using System.Text.RegularExpressions;
namespace emailvalidation
{
    class Solution
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter a mail");
            string input1=Console.ReadLine();
            if(input1.Length<=100 && Regex.IsMatch(input1, @"^[a-zA-Z0-9._+]+\@[a-z]+\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine("email is valid");
            }
            else
            {
                Console.WriteLine("email is not valid");
            }
        }
    }
}
