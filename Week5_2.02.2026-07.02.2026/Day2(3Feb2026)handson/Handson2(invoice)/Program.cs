using System;
using System.Text.RegularExpressions;

namespace Bill_amount
{
    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter increment:");
            int input3 = Convert.ToInt32(Console.ReadLine());

            int reading1 = 0;

            Console.WriteLine("Enter invoice number:");
            string input1 = Console.ReadLine();

            string pattern = @"\d+";

            foreach (Match m in Regex.Matches(input1, pattern))
            {
                reading1 = int.Parse(m.Value);
            }

            int new_increment = reading1 + input3;
            Console.WriteLine("new increment part is " + new_increment);

            input1 = Regex.Replace(input1, @"\d+", new_increment.ToString());
            Console.WriteLine("New invoice number is " + input1);
        }
    }
}
