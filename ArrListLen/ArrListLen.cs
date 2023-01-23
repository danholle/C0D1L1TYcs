using System;

namespace ArrListLenNS
{
    public class ArrListLen
    {
        public int solution(int[] A)
        { // method solution
            int i = 0;
            int len = 0;
            while (i >= 0)
            {
                len++;
                i = A[i];
            }
            return len;
        } // method solution  
    } // class ArrListLen
} // namespace ArrListLenNS
