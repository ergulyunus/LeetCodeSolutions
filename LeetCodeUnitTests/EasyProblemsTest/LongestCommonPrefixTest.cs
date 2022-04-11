using LeetCode.ProblemSolutions.EasyProblems;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeUnitTests.EasyProblemsTest
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void IsPalindrome_With_Correct_Request_Parameter_Then_OK_Test()
        {
            string[] testparams = new string[3] { "flight", "flow", "flower" };

            var result = LongestCommonPrefix_14.Solution(testparams);
            Assert.Equal("fl",result);
        }
    }
}
