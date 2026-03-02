using System;
using System.Collections.Generic;
namespace sort_insert
{
    class Sort_insert
    {
        public int[] insert_sort(int[]input1,int input2, int input3)
        { if(input2<0)
            {
                return new int[] {-2};
            }
            for(int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    return new int[] {-1};
                }
            }
            List<int> list = new List<int>(input1);
            list.Add(input3);
            list.Sort();

            return list.ToArray();    
        }
    }
    class solution
    {
        static void Main(String[] args)
        {
        int[] input1 = {2,6,3,1,7};
        int input2 =  5;
        int input3 = 5;
        Sort_insert a = new Sort_insert();
        int[] output1 = a.insert_sort(input1,input2,input3);
        
        foreach (int val in output1){
            Console.Write(val + " ");
        }
        }
    }
}