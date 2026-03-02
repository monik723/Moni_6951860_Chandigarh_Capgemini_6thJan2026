using System;

namespace average_evenodd
{
    class Average_evenodd
    {
        public int evenodd_average(int[] input1, int input2)
        {
            if (input2 < 0)
            {
                return -2;
            }

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    return -1;
                }

                if (input1[i] % 2 == 0)
                {
                    evenSum = evenSum + input1[i];
                }
                else
                {
                    oddSum = oddSum + input1[i];
                }
            }

            int totalSum = evenSum + oddSum;

            int average = totalSum / input2;

            return average;
        }
    }
    class Solution
    {
        public static void Main(String[] args)
        {
            int[] input1={1,2,3,4,5,6,};
            int input2=6;
            Average_evenodd obj=new Average_evenodd();
            int output=obj.evenodd_average(input1, input2);
            Console.WriteLine("output is"+ output);
            Console.ReadLine();
            
        }
    }
}
