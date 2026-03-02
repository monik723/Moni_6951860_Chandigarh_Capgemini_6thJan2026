using System;

namespace CountVowel
{
    class Count_vowel
    {
        public int vowelcount(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = char.ToLower(str[i]); // convert to lowercase

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            Count_vowel obj = new Count_vowel();
            int result = obj.vowelcount(input);

            Console.WriteLine("Count of vowels is: " + result);
        }
    }
}
