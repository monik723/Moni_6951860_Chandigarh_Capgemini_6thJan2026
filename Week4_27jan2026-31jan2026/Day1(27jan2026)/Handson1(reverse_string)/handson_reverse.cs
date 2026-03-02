using System;
namespace ReverseString
{
    class Reverse
    {
        public string stringreverse(string str)
        {
            string rev = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                rev = rev+str[i];
                
            }
            return rev;
        }
        class Solution
        {
            public static void Main(String[] args)
            {
                Reverse obj=new Reverse();
                Console.WriteLine("enter the string");
                string input =Console.ReadLine();
                string result =obj.stringreverse(input);
                Console.WriteLine("reverse a string"  +  result);
            }
        }
    }
}