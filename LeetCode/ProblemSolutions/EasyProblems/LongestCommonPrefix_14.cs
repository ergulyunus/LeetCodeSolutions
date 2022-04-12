namespace LeetCode.ProblemSolutions.EasyProblems
{
    public static class LongestCommonPrefix_14
    {
        public static string Solution(string[] strs)
        {
            int length = strs.Length;
            if (length == 0) return "";
            if (length == 1) return strs[0];

            int count = strs[0].Length;
            string prefix = strs[0];

            for (int i = 1; i < length; i++)
            {
                int strsLength = strs[i].Length;
                for (int j = 0; j < count; j++)
                {
                    if (j == strsLength || strs[i][j] != prefix[j])
                    {
                        prefix = prefix.Substring(0, j).ToLowerInvariant();
                        count = prefix.Length;
                        if (count == 0) return "";
                        break;
                    }
                }
            }

            return prefix;
        }
    }
}
