using LeetCode.ProblemSolutions.EasyProblems;
using Xunit;

namespace LeetCodeUnitTests.EasyProblemsTest
{
    public class ValidParantheses
    {
        [Theory]
        [InlineData("{[]}")]
        public void ValidParantheses_With_Correct_Request_Parameter_Then_OK_Test(string param)
        {
            var result = Valid_Parentheses_20.Solution(param);
            Assert.True(result);
        }
    }
}
