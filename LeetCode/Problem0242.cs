using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Problem0242
    {
        [TestCase("anagram", "nagaram",ExpectedResult = true)]
        [TestCase("rat", "car", ExpectedResult = false)]
        [TestCase("a", "aa", ExpectedResult = false)]
        [TestCase("aa", "ab", ExpectedResult = false)]
        [TestCase("aacc", "ccac", ExpectedResult = false)]
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!map.ContainsKey(c))
                    map[c] = 0;
                map[c]++;
            }

            foreach (char c in t)
            {
                if (!map.ContainsKey(c))
                    return false;
                map[c]--;
                if (map[c] < 0)
                    return false;
            }

            return true;
        }

        [TestCase("anagram", "nagaram", ExpectedResult = true)]
        [TestCase("rat", "car", ExpectedResult = false)]
        [TestCase("a", "aa", ExpectedResult = false)]
        [TestCase("aa", "ab", ExpectedResult = false)]
        [TestCase("aacc", "ccac", ExpectedResult = false)]
        public bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] sc = s.ToCharArray();
            Array.Sort(sc);
            char[] tc = t.ToCharArray();
            Array.Sort(tc);

            for (int i = 0; i < sc.Length; i++)
                if (sc[i] != tc[i])
                    return false;

            return true;
        }
    }
}
