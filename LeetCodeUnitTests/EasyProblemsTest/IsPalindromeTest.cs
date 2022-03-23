using LeetCode.ProblemSolutions.EasyProblems;
using Xunit;

namespace LeetCodeUnitTests
{
    public class IsPalindromeTest
    {
        [Theory]
        [InlineData(121)]
        // param: 121 result = true
        public void IsPalindrome_With_Correct_Request_Parameter_Then_OK_Test(int param)
        {
            var result = IsPalindrome_9.Solution(param);
            Assert.True(result);
        }

        [Theory]
        [InlineData(123)]
        // param: 123 result = false
        public void IsPalindrome_With_Correct_Request_Parameter_Then_NOK_Test(int param)
        {
            var result = IsPalindrome_9.Solution(param);
            Assert.False(result);
        }
    }
}
