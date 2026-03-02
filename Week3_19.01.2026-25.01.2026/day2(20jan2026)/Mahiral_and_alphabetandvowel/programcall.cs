using System;

namespace MahirlAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            Console.WriteLine(UserMainCode.ProcessString(word1, word2));
        }
    }
}
