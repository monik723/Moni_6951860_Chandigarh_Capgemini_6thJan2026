using System;

namespace ValidMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            int N1 = Convert.ToInt32(Console.ReadLine());
            int N2 = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            UserMainCode.CheckMarks(X, Y, N1, N2, M);
        }
    }
}
