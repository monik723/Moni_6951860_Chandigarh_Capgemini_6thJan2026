using System;
using System.Collections.Generic;

namespace MinOperations
{
    class UserMainCode
    {
        public static int MinOperations(int N)
        {
            if (N == 10)
                return 0;

            Queue<int> q = new Queue<int>();
            Dictionary<int, int> dist = new Dictionary<int, int>();

            q.Enqueue(10);
            dist[10] = 0;

            while (q.Count > 0)
            {
                int cur = q.Dequeue();
                int steps = dist[cur];

                // Possible operations
                int[] nextVals = new int[3];
                nextVals[0] = cur + 2;
                nextVals[1] = cur - 1;
                nextVals[2] = cur * 3;

                foreach (int next in nextVals)
                {
                    // Limit range to avoid infinite loop
                    if (next < 0 || next > 100000)
                        continue;

                    if (!dist.ContainsKey(next))
                    {
                        dist[next] = steps + 1;

                        if (next == N)
                            return dist[next];

                        q.Enqueue(next);
                    }
                }
            }

            return -1; // theoretically won't happen
        }
    }
}
