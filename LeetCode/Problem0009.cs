using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Problem0009
    {

        [TestCase(252, ExpectedResult = true)]
        [TestCase(121, ExpectedResult = true)]
        [TestCase(-121, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        public bool IsPalindrome(long x)
        {
            long q = x;
            if (x < 0)
                q *= -1;

            long n = 0;
            while (q >= 10)
            {
                n = (n + q % 10) * 10;
                q /= 10;
            }
            n += q;
            Console.WriteLine(n);
            if (n == x)
                return true;
            return false;
        }

        [TestCase(252, ExpectedResult = true)]
        [TestCase(121, ExpectedResult = true)]
        [TestCase(-121, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        public bool IsPalindrome2(long x)
        {
            long q = x;
            if (x < 0)
                q *= -1;

            long r = 0;
            long n = 0;
            while (q >= 10)
            {
                r = q % 10;
                q /= 10;

                n = (n + r) * 10;
            }
            n += q;
            Console.WriteLine(n);
            if (n == x)
                return true;
            return false;
        }
    }
}
