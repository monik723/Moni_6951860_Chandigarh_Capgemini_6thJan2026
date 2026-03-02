using System;
namespace product_max_min
{
    class Product_max_min
    {
        public int maxmin_product(int[]input1,int input2)
        { if(input2<0)
            {
                return -2;
            }
            for(int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    return -1;
                }
                    }
                Array.Sort(input1);
               int maximum= input1[input2 -1];
               int minimum= input1[0];
               int product =minimum * maximum;
               return product;

            

        }
    }
    class Solution
    {
        public static void Main(String[] args)
        {
            int[] input1={1,4,3,5,2};
            int input2=5;
           Product_max_min obj = new Product_max_min();
           int output = obj.maxmin_product(input1,input2);
           Console.WriteLine("output is" + output);
           Console.ReadLine();
        }
    }
}