using System;
namespace multiple
{
    class MultipleofThree
    {
        public int threemultiple(int[] input1,int input2)
        {
            if(input2<0)
            {
                return -2;
            }

          for(int i=0;i<input2;i++)
            {
                if(input1[i]<0)
                {
                    return -1;
                }
                }
                int Count=0;
          for(int i=0;i<input2;i++)

            {
                if(input1[i] % 3==0)
                {
                    Count++;
                }
            } 
            return Count;         
        }

    }

    class Solution
    {
        public static void Main(String[] args)
        {   int[] input1={1,2,3,4,5,6};
       int input2 =6;
            MultipleofThree b = new MultipleofThree();
            int result=b.threemultiple(input1,input2);
            Console.WriteLine(result);


        }
    }
}