using System;

namespace decimal_to_binary
{
    class DecimalToBinary
    {
        public int[] convert(int input1)
        {
            
            if (input1 < 0)
            {
                return new int[] { -1 };
            }

           
            if (input1 == 0)
            {
                return new int[] { 0 };
            }

            int num = input1;
            int[] temp = new int[32];  
            int index = 0;

            
            while (num > 0)
            {
                temp[index] = num % 2;
                num = num / 2;
                index++;
            }

            
            int[] output = new int[index];

           
           
            for (int i = 0; i < index; i++)
            {
                output[i] = temp[index - i - 1];
            }

            return output;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            int input1 = 13;

            DecimalToBinary obj = new DecimalToBinary();
            int[] output = obj.convert(input1);

            Console.Write("Binary Output: ");
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
            }
        }
    }
}
