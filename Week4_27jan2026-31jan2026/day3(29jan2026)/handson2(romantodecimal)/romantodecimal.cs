using System;
using System.Collections.Generic;

namespace RomanToDecimal
{
    class UserProgramCode
    {
        public static int convertRomanToDecimal(string input)
        {
            // Roman values
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // Invalid character check
                if (!romanValues.ContainsKey(input[i]))
                {
                    return -1;
                }

                int current = romanValues[input[i]];

                // Check next character
                if (i + 1 < input.Length)
                {
                    // Also ensure next character is valid
                    if (!romanValues.ContainsKey(input[i + 1]))
                    {
                        return -1;
                    }

                    int next = romanValues[input[i + 1]];

                    if (current < next)
                    {
                        total -= current;
                    }
                    else
                    {
                        total += current;
                    }
                }
                else
                {
                    total += current;
                }
            }

            return total;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = UserProgramCode.convertRomanToDecimal(input);

            Console.WriteLine(result);
        }
    }
}
