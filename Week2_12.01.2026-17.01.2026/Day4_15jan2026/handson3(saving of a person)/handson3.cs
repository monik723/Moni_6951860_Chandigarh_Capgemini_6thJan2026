using System;

namespace saving_of_person
{
    class Saving_of_person
    {
        public int person_saving(int input1, int input2)
        {
            if (input1 > 9000)
            {
                return -1;
            }
            if (input1 < 0)
            {
                return -2;
            }
            if (input2 < 0)
            {
                return -4;
            }

            int bonus = 0;

            int food_expenses = (input1 * 50) / 100;
            int travel_expenses = (input1 * 20) / 100;

            int expenses = food_expenses + travel_expenses;

            if (input2 == 31)
            {
                bonus = 500;
            }

            int savings = input1 + bonus - expenses;
            return savings;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int input1 = 8000;
            int input2 = 31;

            Saving_of_person obj = new Saving_of_person();
            int output = obj.person_saving(input1, input2);

            Console.WriteLine("Output is " + output);
            Console.ReadLine();
        }
    }
}
