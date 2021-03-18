using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _349_两个数组的交集
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //求交集的方法
            IEnumerable<int> both = nums1.Intersect(nums2);
            return both.ToArray();
        }
        public int[] Intersection1(int[] nums1, int[] nums2)
        {
            List<int> num1 = nums1.Distinct().ToList();
            List<int> num2 = nums2.Distinct().ToList();
            List<int> res = new List<int>();

            for (int i = 0; i < num2.Count; i++) 
            {
                if (num1.Contains(num2[i])) 
                {
                    res.Add(num2[i]);
                }
            }
            return res.ToArray();
        }

    }
}
