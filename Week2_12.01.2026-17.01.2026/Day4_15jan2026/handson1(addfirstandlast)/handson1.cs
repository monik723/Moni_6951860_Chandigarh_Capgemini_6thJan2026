using System;

namespace add_element
{
    class add_element
    {
        public int[] element_add(int[] input1, int[] input2, int input3)
        {
            if (input3 < 0)
            {
                return new int[] { -2 };
            }

            for (int i = 0; i < input3; i++)
            {
                if (input1[i] < 0 || input2[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            int[] output = new int[input3];
            int j = input3 - 1;

            // ✅ FIXED HERE
            for (int i = 0; i < input3; i++)
            {
                output[i] = input1[i] + input2[j];
                j--;
            }

            return output;
        }
    }

    class Solution
    {
        public static void Main(String[] args)
        {
            add_element obj = new add_element();

            int[] input1 = { 1, 2, 3, 4 };
            int[] input2 = { 4, 3, 2, 1 };
            int input3 = 4;

            int[] output = obj.element_add(input1, input2, input3);

            Console.WriteLine("Output:");
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
