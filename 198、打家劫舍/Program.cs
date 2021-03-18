using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _198_打家劫舍
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Rob1(int[] nums)
        {
            if (nums.Length == 0) 
            {
                return 0;
            }
            int[] dp = new int[nums.Length + 1];
            dp[0] = 0;
            dp[1] = nums[0];
            for (int i = 2; i <= nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i - 1]);
            }
            return dp[nums.Length];       
        }

        public static int Rob(int[] nums)
        {
            int cur = 0;
            int pre = 0;
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                temp = Math.Max(pre + nums[i], cur);
                pre = cur;
                cur = temp;
            }
            return cur;
        }
    }
}
