using System.Collections;
using System.Collections.Generic;

namespace LeetCodeUnitTests.Helper
{
    public class TwoSumTestDataGenerator : IEnumerable<object[]>
    {
        private static readonly List<object[]> _data = new List<object[]>
        {
            new object[] { new int[] { 3,2,4 } } // target: 6 result = [1,2]
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
