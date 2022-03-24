using LeetCode.ProblemSolutions.EasyProblems;
using Xunit;

namespace LeetCodeUnitTests.EasyProblemsTest
{
    public class RomanToIntegerTest
    {
        [Theory]
        [InlineData("III")]
        // param: 121 result = true
        public void RomanToInteger_With_Correct_Request_Parameter_Then_OK_Test(string param)
        {
            var result = RomanToInteger_13.Solution(param);
            Assert.Equal(3,result);
        }
    }
}
