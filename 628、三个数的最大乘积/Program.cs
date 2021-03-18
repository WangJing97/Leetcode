using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _628_三个数的最大乘积
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int MaximumProduct(int[] nums)
        {
            //先排序再按照顺序最前面的三个数和最后的三个数字相乘
            Array.Sort(nums);
            int n = nums.Length;

            //最大的三个数字和最小的两个负数的情况会有最大值
            return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 3] * nums[n - 2] * nums[n - 1]);
        }

        public int MaximumProduct1(int[] nums)
        {
            //其实要的就是找到三个最大值，和两个最小值
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            foreach (int num in nums)
            {
                if (num > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2)
                {
                    max3 = max2;
                    max2 = num;
                }
                else if (num > max3)
                {
                    max3 = num;
                }

                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2) 
                {
                    min2 = num;
                }
            }

            return Math.Max(max1 * max2 * max3, max1 * min1 * min2);
            
        }

    }
}
