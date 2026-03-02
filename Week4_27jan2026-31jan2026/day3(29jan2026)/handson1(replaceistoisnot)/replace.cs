using System;
using System.Text.RegularExpressions;

namespace Replace_character
{
    class UserProgramCode
    {
        public string negativeString(string str)
        {
            // Replace only the word "is" with "is not"
            string result = Regex.Replace(str, @"\bis\b", "is not");
            return result;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            string input1 = Console.ReadLine();
            Console.WriteLine("input is " + input1);

            UserProgramCode obj = new UserProgramCode();
            string output = obj.negativeString(input1);

            Console.WriteLine("output is " + output);
        }
    }
}
