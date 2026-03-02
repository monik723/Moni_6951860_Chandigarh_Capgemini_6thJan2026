using System;
using System.Text.RegularExpressions;

namespace Bill_amount
{
    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter rate per unit:");
            int input3 = Convert.ToInt32(Console.ReadLine());

            int reading1 = 0;
            int reading2 = 0;

            Console.WriteLine("Enter first reading:");
            string input1 = Console.ReadLine();
            string pattern = @"\d+";

            foreach (Match m in Regex.Matches(input1, pattern))
                reading1 = int.Parse(m.Value);

            Console.WriteLine("Enter second reading:");
            string input2 = Console.ReadLine();
            string pattern2 = @"\d+";

            foreach (Match m in Regex.Matches(input2, pattern2))
                reading2 = int.Parse(m.Value);

            int c = Math.Abs(reading1 - reading2);
            int amount = input3 * c;

            Console.WriteLine("The amount is " + amount);
        }
    }
}
