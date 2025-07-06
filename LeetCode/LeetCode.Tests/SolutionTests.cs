namespace LeetCode.Tests
{
    public class SolutionTests
    {
        [Theory()]
        [InlineData(new int[] { 2, 2, 3, 4 }, 2)]
        [InlineData(new int[] { 1, 2, 2, 3, 3, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 2, 3, 3 }, -1)]

        public void LuckyNumberTests(int[] array, int expectedValue)
        {
            //given
            Solution solution = new Solution();
            //when
            int actualValue = solution.FindLucky(array);
            //then
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory()]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumTests(int[] nums, int target, int[] expected)
        {
            //given
            Solution solution = new Solution();
            //when
            
            int[] actual = solution.TwoSum(nums,target);
            //then
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equivalent(expected, actual,strict:true);
        }

        [Theory()]
        [InlineData("abcabcbb",3)]
        [InlineData("bbbbb",1)]
        [InlineData("pwwkew",3)]
        [InlineData(" ",1)]
        [InlineData("aab",2)]
        public void LengthOfLongestSubstring(string str, int expectedLength)
        {
            //given
            Solution solution = new Solution();
            //when
            int actualLength = solution.LengthOfLongestSubstring(str);
            //then
            Assert.Equal(expectedLength, actualLength);
        }
    }
}