using System;

class Solution
{
    public static void LastBallPass(int N, int T)
    {
        int current = 1;  // Friend who has the ball initially
        int next = 0;

        for (int time = 1; time <= T; time++)
        {
            next = current + 1;

            // Circular passing
            if (next > N)
                next = 1;

            // If this is the last second, print result
            if (time == T)
            {
                Console.WriteLine("At last second, Friend " + current +
                                  " passed the ball to Friend " + next);
            }

            current = next;
        }
    }

    static void Main()
    {
        int N = 4;
        int T = 10;

        LastBallPass(N, T);
    }
}
