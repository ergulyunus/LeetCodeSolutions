using System.Collections.Generic;

namespace LeetCode.ProblemSolutions.EasyProblems
{
    public static class Valid_Parentheses_20
    {
        public static bool Solution(string s)
        {
            if (s.Length == 0) return false;
            if (s.Length % 2 == 1) return false;

            int n = -1;
            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "").Replace("{}", "").Replace("[]", "");
            }
            if (s.Length == 0) return true;
            else return false;
        }
    }
}
