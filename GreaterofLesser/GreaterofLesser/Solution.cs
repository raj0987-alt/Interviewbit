using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterofLesser
{
    internal class Solution
    {
        public int solve(List<int> A, List<int> B, int C)
        {
            int r = 0;
            int g = 0;
            int l = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > C)
                {
                    g++;
                }
            }
            for (int i = 0; i < B.Count; i++)
            {
                if (B[i] < C)
                {
                    l++;
                }
            }
            if (g > l)
            {
                return g;
            }
            else
            {
                return l;
            }
        }
    }
}
