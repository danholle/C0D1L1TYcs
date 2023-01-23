using System;

namespace SparseBinaryDecompositionNS
{
    static int m101 = 0b01010101010101010101010101010101;
    static int m010 = ob00101010101010101010101010101010;
    public class SparseBinaryDecomposition
    {
        
        public int solution(int N)
        {
            return m010 & N;
        } // method solution
    } // class SparseBinaryDecomposition
} // namespace SparseBinaryDecompositionNS
