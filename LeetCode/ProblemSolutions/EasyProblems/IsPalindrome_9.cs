namespace LeetCode.ProblemSolutions.EasyProblems
{
    public static class IsPalindrome_9
    {
        public static bool Solution(int x)
        {
            if (x < 0) return false;
            var y = 0;
            var z = x;
            while (z > 0)
            {
                y = y * 10 + z % 10;
                z /= 10;
            }
            return (y == x);
        }
    }
}
