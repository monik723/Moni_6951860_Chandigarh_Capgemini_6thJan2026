using System;

namespace DigitSumInString
{
    class UserProgramCode
    {
        public static int sumOfDigits(string[] input1)
        {
            int sum = 0;

            foreach (string str in input1)
            {
                foreach (char ch in str)
                {
                    if (char.IsDigit(ch))
                    {
                        sum += ch - '0';
                    }
                    else if (char.IsLetter(ch))
                    {
                        continue;
                    }
                    else
                    {
                        // special character or space found
                        return -1;
                    }
                }
            }
            return sum;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the string array");

            string[] input1 = new string[n];

            for (int i = 0; i < input1.Length; i++)
            {
                input1[i] = Console.ReadLine();
            }

            int result = UserProgramCode.sumOfDigits(input1);
            Console.WriteLine(result);
        }
    }
}
