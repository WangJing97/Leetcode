using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _643_子数组最大平均数_I
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public double FindMaxAverage(int[] nums, int k)
        {
            //使用滑动窗口 ，计算窗口中的平均值
            double result = 0;
            double sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
                result = sum / k;
            }
            for (int i = k; i < nums.Length; i++)
            {
                sum = sum + nums[i] - nums[i - k];
                result = Math.Max(result, sum / k);
            }
            return result;
        }
    }
}
