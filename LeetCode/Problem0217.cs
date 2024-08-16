using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Problem0217
    {

        [TestCase(new int[] { 1, 2, 3, 4, 1 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 1, 3, 4 }, ExpectedResult = true)]
        public bool ContainsDuplicate(int[] nums)
        {

            return new HashSet<int>(nums).Count != nums.Length;
        }

        [TestCase(new int[] { 1, 2, 3, 4, 1 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 1, 3, 4 }, ExpectedResult = true)]
        public bool ContainsDuplicate2(int[] nums)
        {
            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        [TestCase(new int[] { 1, 2, 3, 4, 1 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 1, 3, 4 }, ExpectedResult = true)]
        public bool ContainsDuplicate3(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
