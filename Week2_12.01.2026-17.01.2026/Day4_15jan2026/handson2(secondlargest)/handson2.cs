using System;
namespace secondlargest
{
    class Second_largest
    {
        public static int largest_second(int[] input1,int input3)
        {
            if(input3<0)
            {
                return -2;
            }
            for(int i=0;i<input3;i++)
            {
                if(input1[i]<0)
                {
                    return -1;
                }
               
            }
             Array.Sort(input1);
                return input1[input3 - 2];
        }
    }
    class Solution
    {
        public static void Main(String[] args)
        {
           int[] input1={4,2,7,6,1};
           int input3=5; 
           int output=Second_largest.largest_second(input1,input3);
           Console.WriteLine(output);

        }
    }
}