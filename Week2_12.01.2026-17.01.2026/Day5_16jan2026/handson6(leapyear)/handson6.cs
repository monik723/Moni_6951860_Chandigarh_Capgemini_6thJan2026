using System;
namespace find_leap
{
    class Find_leap
    {
        public int leap_find(int input1)
        {
            if (input1 < 0)
            {
                return -1;
            }
            if(input1 % 400 ==0 || (input1 % 4==0 && input1 % 100 !=0))
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
            int input1=2024;
            Find_leap obj=new Find_leap();
            int output=obj.leap_find(input1);
            if (output == 1)
            {
                Console.WriteLine("it is a leap year");
            }
            if(output == 0)
            {
                Console.WriteLine("it is not a leap year");
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}