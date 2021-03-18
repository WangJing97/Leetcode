using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int res = MaxSubArray(nums);
            int res = MaxSubArray1(nums);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        //暴力搜索
        public static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }
            return max;
        }
        //新方法
        public static int MaxSubArray1(int[] nums)
        {
            //          -1    2      3        -2      1
            //maxTocur  -1    1/2√   2+3√/3   3√/-2   4√/1   
            //max       -1    2      5        5       5
            //maxTocur：Max(maxTocur+num[i],num[i])
            //max：Max(max,maxTocur)
            int maxToCurr = nums[0];
            int sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxToCurr = Math.Max(maxToCurr + nums[i], nums[i]);
                sum = Math.Max(sum, maxToCurr);
            }
            return sum;
        }
    }
}
