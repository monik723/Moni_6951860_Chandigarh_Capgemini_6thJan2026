using System;
using System.Text.RegularExpressions;
namespace phonenumber
{
    class Solution
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter a number");
            string input1=Console.ReadLine();
          string pattern = @"\d{10}";

foreach (Match m in Regex.Matches(input1, pattern))
    Console.WriteLine(m.Value);
        }
    }
}
