using Xunit;

namespace PracticeConsole
{
    public class BinaryGapTC
    {

        BinaryGap x = new BinaryGap();
        
        [Theory]
        [InlineData(5,1)]                       
        [InlineData(2147483647,0)]
        [InlineData(328,2)]
        [InlineData(16,0)]
        [InlineData(124,0)]
        [InlineData(9,2)]
        [InlineData(11,1)]
        [InlineData(19,2)]
        [InlineData(42,1)]
        [InlineData(20,1)]
        [InlineData(561892,3)]
        [InlineData(6291457,20)]
        [InlineData(1073741825,29)]
        [InlineData(1610612737,28)]
        public void Test(long N, int expected)
        {
            Assert.Equal(expected,x.Solution(N));
        }
    }
}