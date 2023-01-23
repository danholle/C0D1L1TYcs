using System;

namespace BinaryGapNS
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            int n = N;
            int gap = 0;
            int maxgap = 0;
            int bit = 1;

            // Looking at the rightmost bit, and shifting right 1
            // after each step.  Values of "state"
            //  0 means we haven't received a 1 yet so still looking
            //  1 means we saw a 1 and are now looking for a 0 to start the gap
            //  2 we are counting 0's, looking for a 1 to stop this gap
            int state = 0;

            while (n!=0)
            {
                bit = (n&1);
                switch (state)
                {
                    case 0: // looking for a 1 as possible right border of gap
                        if (bit == 1) state = 1;
                        break;
                    case 1: // looking for first 0 in the gap
                        if (bit==0) {gap = 1; state=2;}
                        break;
                    case 2: 
                        if (bit==1) {state=1; if (gap>maxgap) maxgap=gap;}
                        else gap+=1;
                        break;
                    default:
                        break;       
                } // switch
                n = n>>1;
            } // while remaining bitstring is not 0
            return maxgap;
        } // method solution
    } // class BinaryGap
} // namespace BinaryGapNS
