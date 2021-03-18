using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _303_区域和检索___数组不可变
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class NumArray
    {
        //暴力法 会超时
        private int[] data;
        //使用数组 nums 初始化对象
        public NumArray(int[] nums)
        {
            data = nums;
        }
        //返回数组 nums 从索引 i 到 j（i ≤ j）范围内元素的总和，
        //包含 i、j 两点（也就是 sum(nums[i], nums[i + 1], ... , nums[j])）
        public int SumRange(int i, int j)
        {
            int sum = 0;
            for (int k = i; k <= j; k++)
            {
                sum += data[k];
            }
            return sum;
        }
    }
    public class NumArray1
    {
        private int[] sum;
        public NumArray1(int[] nums)
        {
            sum = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
            }
        }

        public int SumRange(int i, int j)
        {
            //sum[k] 定义为 nums[0⋯⋯⋯k-1] 的和。包括这两个值
            //所以SumRange就是
            //sumrange（i，j）=sum[j+1]−sum[i]
            //注意0
            //举例输入[-2, 0, 3, -5, 2, -1]
            //一开始就会
            //sum[]={0,0+-2,0+-2+0,0+-2+0+3⋯⋯⋯⋯⋯⋯}
            //sum[]={0,a,a+b,a+b+c,a+b+c+d,a+b+c+d+e⋯⋯⋯⋯⋯⋯}
            //sumrange（i，j）=sum[j+1]−sum[i] 0 2
            //a+b+c-0=a+b+c
            //1 3
            //a+b+c+d-a=b+c+d
            return sum[j + 1] - sum[i];
        }
    }

}
