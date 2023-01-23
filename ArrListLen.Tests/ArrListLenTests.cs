using NUnit.Framework;
using ArrListLenNS;

namespace ArrListLenTestsNS
{
    [TestFixture]
    public class ArrListLenTests
    {
        private ArrListLen _ArrListLen;

        [SetUp]
        public void Setup()
        {
            _ArrListLen = new ArrListLen();
        } // method Setup

        [Test]
        [TestCase(new[] {1,4,-1,3,2}, 4)]
        public void Test3(int[] A, int ans)
        {
            Assert.IsTrue(_ArrListLen.solution(A)==ans);
        } // method Test3
    } // class ArrListLenTests
} // namespace ArrListLenTestsNS

