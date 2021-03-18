using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _594_最长和谐子序列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 2, 2, 5, 2, 3, 7 };
            int i = FindLHS(nums);
        }
        public static int FindLHS(int[] nums)
        {
            //统计每个数字出现的次数，排序，然后比较
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (!dic.ContainsKey(i)) dic.Add(i, 1);
                else dic[i]++;
            }
            int res = 0;
            foreach (int key in dic.Keys)
            {
                if (dic.ContainsKey(key + 1)) 
                {
                    res = Math.Max(res, dic[key] + dic[key + 1]);
                }
            }
            return res;
        }
    }
}
