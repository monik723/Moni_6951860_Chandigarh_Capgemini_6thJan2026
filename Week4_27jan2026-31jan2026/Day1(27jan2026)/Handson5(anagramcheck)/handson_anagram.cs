using System;

class AnagramCheck
{
    static bool IsAnagram(string s1, string s2)
    {
        // Remove spaces and convert to lowercase
        s1 = s1.Replace(" ", "").ToLower();
        s2 = s2.Replace(" ", "").ToLower();

        // If lengths are not equal, not anagram
        if (s1.Length != s2.Length)
            return false;

        // Convert to char array and sort
        char[] arr1 = s1.ToCharArray();
        char[] arr2 = s2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        // Compare sorted strings
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter second string:");
        string str2 = Console.ReadLine();

        if (IsAnagram(str1, str2))
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are NOT Anagrams");
    }
}