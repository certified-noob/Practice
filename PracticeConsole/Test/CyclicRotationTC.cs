using Xunit;

namespace PracticeConsole
{
    public class CyclicRotationTC
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        public void TestName(int[] A, int K, int[] expected)
        {
            CyclicRotation x = new CyclicRotation();
            Assert.Equal(expected, x.Solution(A, K));
        }
    }
}