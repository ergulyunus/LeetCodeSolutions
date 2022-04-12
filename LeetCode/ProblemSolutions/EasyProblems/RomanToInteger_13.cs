using System.Collections.Generic;
using System.Linq;

namespace LeetCode.ProblemSolutions.EasyProblems
{
    public static class RomanToInteger_13
    {
        public static int Solution(string s)
        {
            List<KeyValuePair<char, int>> romans = new List<KeyValuePair<char, int>>
            {
                new KeyValuePair<char, int>('I',1),
                new KeyValuePair<char, int>('V',5),
                new KeyValuePair<char, int>('X',10),
                new KeyValuePair<char, int>('L',50),
                new KeyValuePair<char, int>('C',100),
                new KeyValuePair<char, int>('D',500),
                new KeyValuePair<char, int>('M',1000),
            };

            if (s.Length == 1) { return romans.First(kvp => kvp.Key == s[0]).Value; }

            var total = romans.First(kvp => kvp.Key == s[0]).Value;

            for (int i = 1; i < s.Length; i++)
            {
                total += romans.First(kvp => kvp.Key == s[i]).Value; ;
                if (romans.First(kvp => kvp.Key == s[i - 1]).Value < romans.First(kvp => kvp.Key == s[i]).Value)
                {
                    total -= (romans.First(kvp => kvp.Key == s[i - 1]).Value * 2);
                }
            }

            return total;
        }
    }
}
