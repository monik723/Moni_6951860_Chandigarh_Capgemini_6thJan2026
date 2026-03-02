using System;
namespace sum_factor
{
    class Sum_factor
    {
        public int factor_sum(int input1,int input2)
        {
            if (input1 < 0)
            {
                return -1;
            }
            if(input2>32627)
            {
                return -2;
            }
            int sum=0;
            for(int i=input1;i<=input2;i+=input1)
            {
                sum=sum+input1;
            }
            return sum;
        }
    }
    class Solution
    {
        public static void Main(String[] args)
        {
            int input1=3;
            int input2=15;
            Sum_factor obj=new Sum_factor();
            int output=obj.factor_sum(input1,input2);
            Console.WriteLine("output is" + output);
            Console.ReadLine();
        } 
    }
}
