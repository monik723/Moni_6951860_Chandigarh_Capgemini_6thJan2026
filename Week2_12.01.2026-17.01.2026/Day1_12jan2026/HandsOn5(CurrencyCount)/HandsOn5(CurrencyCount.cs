using System;

namespace currencycount
{
    class CountCurrency
    {
        public int currency(int amount)
        {
            if (amount < 0)
            {
                return -1;
            }
            int count=0;

            int n500 =amount/500;
                amount=amount%500;
                count=count+n500;

                int n100 =amount/100;
                amount=amount%100;
                count=count+n100;

                int n50 =amount/50;
                amount=amount%50;
                count=count+n50;

                int n10 =amount/10;
                amount=amount%10;
                count=count+n10;

                int n1 =amount/1;
                 count=count+n1;
                 return count;

            }
            }

            class Solution
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter the amount");
             int amount = int.Parse(Console.ReadLine());
            CountCurrency b=new CountCurrency();
            int output= b.currency(amount);
            
        Console.WriteLine("Output1 = " + output);
            
        }
    }
            }
            
        