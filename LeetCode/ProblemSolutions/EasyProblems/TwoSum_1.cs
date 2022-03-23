﻿namespace LeetCode.ProblemSolutions
{
    public static class TwoSum_1
    {
        public static int[] Solution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                        return new int[2] { i, j };
                }
            }
            return new int[2];
        }
    }
}
