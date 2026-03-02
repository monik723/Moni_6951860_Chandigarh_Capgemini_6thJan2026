using System;
namespace calculate_salary
{
    class Calculate_salary
    {
        public int salary_calaculate(int input1,int input2)
        {
            if(input1<0)
            {
                return -1;
            }
            if(input1>10000)
            {
                return -2;
            }
            if(input2>31)
            {
                return -3;
            }
            int da=(input1 * 75)/100;
            int hra=(input1 * 50)/100;
            int total_gross_salary=input1+da+hra;
            return total_gross_salary;
                    
    }
}
class Solution
    {
        public static void Main(String[] args)
        {
           int input1=9000;
           int input2=30;
            Calculate_salary obj =new Calculate_salary();
            int output=obj.salary_calaculate(input1,input2);
            Console.WriteLine("output is" + output);
            Console.ReadLine();
        }
    }
}