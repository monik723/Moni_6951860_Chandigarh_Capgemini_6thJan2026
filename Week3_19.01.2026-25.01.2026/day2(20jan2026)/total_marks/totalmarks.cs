using System;

namespace ValidMarks
{
    class UserMainCode
    {
        public static void CheckMarks(int X, int Y, int N1, int N2, int M)
        {
            bool found = false;
            int bestType1 = -1;
            int bestType2 = -1;

            // Try all possible correct answers of type 1 and type 2
            for (int i = 0; i <= N1; i++)  // i = correct Type 1
            {
                for (int j = 0; j <= N2; j++) // j = correct Type 2
                {
                    int total = i * X + j * Y;

                    if (total == M)
                    {
                        // We want MAXIMUM number of type 1 answers
                        if (i > bestType1)
                        {
                            bestType1 = i;
                            bestType2 = j;
                            found = true;
                        }
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(bestType1);
                Console.WriteLine(bestType2);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
