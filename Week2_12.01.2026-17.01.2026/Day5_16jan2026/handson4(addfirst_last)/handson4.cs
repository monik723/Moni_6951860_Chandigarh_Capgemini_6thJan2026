using System;

namespace add_firstlast
{
    class Add_firstlast
    {
        public int[] firstlast_add(int[] input1, int[] input2, int input3)
        {
            if (input3 < 0)
            {
                return new int[] { -2 };
            }

            for (int i = 0; i < input3; i++)
            {
                if (input1[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            for (int i = 0; i < input3; i++)
            {
                if (input2[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            int[] add = new int[input3];

            for (int i = 0; i < input3; i++)
            {
                add[i] = input1[i] + input2[input3 - 1 - i];
            }

            return add;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] input2 = { 5, 4, 3, 2, 1 };
            int input3 = 5;

            Add_firstlast obj = new Add_firstlast();
            int[] output = obj.firstlast_add(input1, input2, input3);

            foreach (int val in output)
            {
                Console.Write(val + " ");
            }

            Console.ReadLine();
        }
    }
}
