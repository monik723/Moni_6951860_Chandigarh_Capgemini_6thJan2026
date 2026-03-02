using System;

namespace perform_operation
{
    class Perform_operation
    {
        public int oprtaion_perform(int input1, int input2, int input3)
        {
            if (input1 < 0 || input2 < 0)
            {
                return -1;
            }

            switch (input3)
            {
                case 1:
                    return input1 + input2;

                case 2:
                    return input1 - input2;

                case 3:
                    return input1 * input2;

                case 4:
                    if (input2 == 0)
                        return -1;   // division by zero protection
                    return input1 / input2;

                default:
                    return -1;
            }
        }
    }
    class Solution
    {
        public static void Main(String[] args)
        {   Console.WriteLine("Enter input1:");
            int input1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input2:");
            int input2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input3:");
            int input3=Convert.ToInt32(Console.ReadLine());
            Perform_operation obj =new Perform_operation();
            int output=obj.oprtaion_perform(input1,input2,input3);
            Console.WriteLine("outputis" + output);
            Console.ReadLine();

        }
    }
}
