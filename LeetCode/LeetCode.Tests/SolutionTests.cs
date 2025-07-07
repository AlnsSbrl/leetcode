namespace LeetCode.Tests
{
    public class SolutionTests
    {
        public Solution solution;

        public SolutionTests()
        {
            solution = new Solution();
        }

        [Theory()]
        [InlineData(new int[] { 2, 2, 3, 4 }, 2)]
        [InlineData(new int[] { 1, 2, 2, 3, 3, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 2, 3, 3 }, -1)]

        public void LuckyNumberTests(int[] array, int expectedValue)
        {
            //given
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
            //when

            int[] actual = solution.TwoSum(nums, target);
            //then
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equivalent(expected, actual, strict: true);
        }

        [Theory()]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData(" ", 1)]
        [InlineData("aab", 2)]
        public void LengthOfLongestSubstring(string str, int expectedLength)
        {
            //given
            //when
            int actualLength = solution.LengthOfLongestSubstring(str);
            //then
            Assert.Equal(expectedLength, actualLength);
        }


        [Theory()]
        [InlineData("babad",new string[] {"bab","aba"})]
        [InlineData("cbbd",new string[] {"bb"})]
        [InlineData("a",new string[] {"a"})]
        [InlineData("ac",new string[] {"a","c" })]
        [InlineData("xaabacxcabaaxcabaax",new string[] { "xaabacxcabaax" })]
        
        public void LongestPalindromeTests(string str, string[] expectedAnswers)
        {
            string actualAnswer = solution.LongestPalindrome(str);
            Assert.Contains(actualAnswer, expectedAnswers);
        }

        [Theory()]
        [InlineData("aab", false)]
        [InlineData("aabbaa",true)]
        [InlineData("aabaa",true)]
        public void IsStringAPalindromeTests(string str, bool isAPalindromeExpectation)
        {
            bool isAPalindromeActual = solution.IsStringAPalindrome(str);
            Assert.Equal(isAPalindromeActual, isAPalindromeExpectation);
        }

        [Theory()]
        [InlineData(123,321)]
        [InlineData(-123,-321)]
        [InlineData(120,21)]
        [InlineData(0,0)]
        [InlineData(-2147483412, -2143847412)]
        public void ReverseIntegerTests(int numberToReverse, int expectedResult)
        {
            //given
            //when
            int actualResult=solution.ReverseInteger(numberToReverse);
            //then
            Assert.Equal(expectedResult, actualResult);

        }
    }
}