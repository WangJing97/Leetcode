using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _350_两个数组的交集_II
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            //解题思路
            //首先遍历第一个数组，记录数组中每个数字的值和出现的频率
            //接着遍历第二个数组中的每个数字，如果表中存在这个数字，则将这个数字添加到答案，并且
            //减少表中的次数
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> res = new List<int>();
            foreach (int n in nums1) 
            {
                if (dic.ContainsKey(n)) 
                {
                    dic[n]++;
                }
                else
                {
                    dic.Add(n, 1);
                }
            }
            foreach (int n in nums2)
            {
                if (dic.ContainsKey(n) && dic[n] > 0) 
                {
                    dic[n]--;
                    res.Add(n);
                }
            }
            return res.ToArray();
        }
        public int[] Intersect1(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0;
            int j = 0;
            List<int> res = new List<int>();
            while (i < nums1.Length && j < nums2.Length) 
            {
                //两个指针，谁小谁++；
                if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else if (nums1[i] > nums2[j]) 
                {
                    j++;
                }
                else
                {
                    res.Add(nums1[i]);
                    i++;
                    j++;
                }
            }
            return res.ToArray();
        }

    }
}
