using System;

namespace CheckPalindrome
{
    class Check_Palindrome
    {
        public string palindromecheck(string str)
        {
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            // Compare after full reverse
            if (rev.ToLower() == str.ToLower())
            {
                return "Palindrome";
            }
            else
            {
                return "Not Palindrome";
            }
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Check_Palindrome obj = new Check_Palindrome();

            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            string result = obj.palindromecheck(input);

            Console.WriteLine("Result: " + result);
        }
    }
}
