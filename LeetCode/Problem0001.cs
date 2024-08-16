using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    [TestFixture]
    internal class Problem0001
    {

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1,2 })]
        [TestCase(new int[] { 3,3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return [i, j];
                }
            }
            return [-1, -1];
        }


        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int comp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                comp = target - nums[i];

                if (dic.ContainsKey(comp))
                    return [dic[comp], i];

                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            return [-1, -1];
        }

    }
}
