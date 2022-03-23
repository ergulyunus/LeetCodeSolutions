using LeetCode.ProblemSolutions;
using LeetCodeUnitTests.Helper;
using Xunit;

namespace LeetCodeUnitTests
{
    public class TwoSumTest
    {
        [Theory]
        [ClassData(typeof(TwoSumTestDataGenerator))]
        // target: 6 result = [1,2]
        public void TwoSum_With_Correct_Request_Parameter_Then_OK_Test(int[] req)
        {
           var result = TwoSum_1.Solution(req, 6);
           Assert.True(result[0] == 1);
           Assert.True(result[1] == 2);
        }
    }
}
