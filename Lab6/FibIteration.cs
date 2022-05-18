using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class FibIteration : FindFib
    {
        public int calculate_fib(int k)
        {
            if (k <= 0)
            {
                return k;
            }

            if (k == 1)
            {
                return 1;
            }

            if (k == 2)
            {
                return 2;
            }

            int answer = 0;
            int f0 = 1;
            int f1 = 1;
            for(int i = 3; i<=k; i++)
            {
                answer = f0 + f1;
                f0 = f1;
                f1 = answer;
            }

            return answer;
        }

    }
}
