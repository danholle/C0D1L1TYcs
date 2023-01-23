using NUnit.Framework;
using ExampleNS;

namespace ExampleTestsNS
{
    [TestFixture]
    public class ExampleTests
    {
        private Example _Example;

        [SetUp]
        public void Setup()
        {
            _Example = new Example();
        } // method Setup

        [Test]
        public void Test1()
        {
            Assert.Pass();
        } // method Test1

        [Test]
        public void Test2()
        {
            Assert.IsTrue(_Example.solution(new[] {1,1})==2);
        } // method Test2

        [Test]
        [TestCase(new[] {1,2}, 3)]
        public void Test3(int[] A, int ans)
        {
            Assert.IsTrue(_Example.solution(A)==ans);
        } // method Test3
    } // class ExampleTests
} // namespace ExampleTestsNS

