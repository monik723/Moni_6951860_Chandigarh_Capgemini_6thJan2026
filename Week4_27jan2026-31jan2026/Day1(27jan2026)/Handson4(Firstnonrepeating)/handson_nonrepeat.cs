using System;

namespace Nonreapeating
{
    class Non_repeat
    {
        public char nonrep(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                bool isRepeating = false;

                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && str[i] == str[j])
                    {
                        isRepeating = true;
                        break;
                    }
                }

                if (!isRepeating) // correct check
                {
                    return str[i];
                }
            }

            return '\0'; // means not found
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Non_repeat obj = new Non_repeat();

            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            char result = obj.nonrep(input);

            if (result == '\0')
            {
                Console.WriteLine("There is no non-repeating character");
            }
            else
            {
                Console.WriteLine("First non-repeating character: " + result);
            }
        }
    }
}
