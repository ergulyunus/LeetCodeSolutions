using LeetCode.ProblemSolutions.EasyProblems;
using Xunit;

namespace LeetCodeUnitTests.EasyProblemsTest
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void LongestCommonPrefix_With_Correct_Request_Parameter_Then_OK_Test()
        {
            string[] testparams = new string[3] { "flight", "flow", "flower" };

            var result = LongestCommonPrefix_14.Solution(testparams);
            Assert.Equal("fl", result);
        }
    }
}
