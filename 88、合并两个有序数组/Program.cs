using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_合并两个有序数组
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //从后往前排好点
            int lenNums1 = m + n - 1;
            while (m > 0 && n > 0) 
            {
                if (nums1[m - 1] > nums2[n - 1]) 
                {
                    nums1[lenNums1] = nums1[m - 1];
                    m--;
                    lenNums1--;
                }
                else
                {
                    nums1[lenNums1] = nums2[n - 1];
                    n--;
                    lenNums1--;
                }                
            }
            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
            }
        }
    }
}
