using NUnit.Framework;
using SparseBinaryDecompositionNS;

namespace SparseBinaryDecompositionTestsNS
{
    [TestFixture]
    public class SparseBinaryDecompositionTests
    {
        private SparseBinaryDecomposition _SparseBinaryDecomposition;

        [SetUp]
        public void Setup()
        {
            _SparseBinaryDecomposition = new SparseBinaryDecomposition();
        } // method Setup

        [Test]
        public void Test1()
        {
            Assert.Pass();
        } // method Test1

        [Test]
        public void Test2()
        {
            Assert.IsTrue(_SparseBinaryDecomposition.solution(new[] {1,1})==2);
        } // method Test2

        [Test]
        [TestCase(new[] {1,2}, 3)]
        public void Test3(int[] A, int ans)
        {
            Assert.IsTrue(_SparseBinaryDecomposition.solution(A)==ans);
        } // method Test3
    } // class SparseBinaryDecompositionTests
} // namespace SparseBinaryDecompositionTestsNS

