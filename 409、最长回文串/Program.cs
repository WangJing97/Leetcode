using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _409_最长回文串
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int LongestPalindrome(string s)
        {
            //思路就是统计每个字符串出现的次数，偶数次放在两边，奇数放在中间 偶数直接加 奇数减一个最后加上中间的一位
            Dictionary<char, int> res = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (res.ContainsKey(c))
                {
                    res[c]++;
                }
                else
                {
                    res.Add(c, 1);
                }
            }
            bool flag = false;
            int sum = 0;
            foreach (var item in res) 
            {
                if (item.Value % 2 == 0) 
                {
                    sum += item.Value;
                }
                else
                {
                    sum += item.Value - 1;
                    flag = true;
                }
            }
            if (flag)
            {
                sum += 1;
            }
            return sum;
        }
    }
}
