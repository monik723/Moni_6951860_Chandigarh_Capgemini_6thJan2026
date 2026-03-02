using System;

namespace find_palindrome
{
    class Find_palindrome
    {
        public int palindrome_find(int input1)
        {
           
            if (input1 < 0)
            
            {
                return -1;
            }

            int rev = 0;
            int original = input1;

            while (input1 > 0)
            {
                int digit = input1 % 10;
                input1 = input1 / 10;
                rev = (rev * 10) + digit;
            }

            if (original == rev)
            {
                return 1;   
            }
            else
            {
                return 0;  
            }
        }
    }

    class Solution
    {
        public static void Main(String[] args)
        {
            int input1 = 1561;

            Find_palindrome obj = new Find_palindrome();
            int output = obj.palindrome_find(input1);

            if (output == -1)
                Console.WriteLine("Invalid input");
            else if (output == 1)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is Not Palindrome");

            Console.ReadLine();
        }
    }
}
