using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    [TestFixture]
    internal class Problem0049
    {


        [TestCase((object)new[] { "eat", "tea", "tan", "ate", "nat", "bat" }, ExpectedResult = new object[] { new[] { "eat", "tea", "ate" }, new[] { "tan", "nat" }, new[] { "bat" } })]
        [TestCase((object)new[] { "a" }, ExpectedResult = new object[] { new[] { "a"} })]
        [TestCase((object)new[] { "" }, ExpectedResult = new object[] { new[] { "" } })]
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var ch = strs[i].ToCharArray();
                Array.Sort(ch);
                var sorted = new string(ch);
                if (map.ContainsKey(sorted))
                {
                    map[sorted].Add(strs[i]);
                }
                else
                {
                    map.Add(sorted, new List<string>() { strs[i] });
                }
            }

            return map.Values.ToList();
        }


    }
}
