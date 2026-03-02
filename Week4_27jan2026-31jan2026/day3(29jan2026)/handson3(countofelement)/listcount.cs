using System;

namespace CountOfElements
{
    class UserProgramCode
    {
        public static int GetCount(int input1, string[] input2, char input3)
        {
            int count = 0;

            // Check each string
            for (int i = 0; i < input1; i++)
            {
                string s = input2[i];

                // 🔴 Business Rule 2: Only alphabets should be given
                foreach (char c in s)
                {
                    if (!char.IsLetter(c))
                    {
                        return -2;
                    }
                }

                // Check starting character (case insensitive)
                if (s.Length > 0 && char.ToLower(s[0]) == char.ToLower(input3))
                {
                    count++;
                }
            }

            // 🔴 Business Rule 1: If no element found
            if (count == 0)
            {
                return -1;
            }

            return count;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            char ch = char.Parse(Console.ReadLine());

            int result = UserProgramCode.GetCount(n, arr, ch);

            if (result == -1)
            {
                Console.WriteLine("No elements Found");
            }
            else if (result == -2)
            {
                Console.WriteLine("Only alphabets should be given");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
