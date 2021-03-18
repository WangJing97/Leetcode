using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169_多数元素
{
    class Program
    {
        static void Main(string[] args)
        {          
        }
        public int MajorityElement(int[] nums)
        {
            //对这个数组进行排序 找最中间的数就是多数元素
            //因为这个数组是非空的，并且给定的数组总是存在多数元素
            Array.Sort(nums);
            return nums[(nums.Length - 1) / 2];
        }
        public int MajorityElement1(int[] nums)
        {
            //摩尔投票法
            //过程：
            //首先初始化两个量：众数和票数，众数初值设置为数组的第一个元素，票数为0
            //往后遍历，遇到相同的数则票数加一，否则减一
            //如果全部抵消票数为0，则设下一个数为当前数
            //最后的当前数就是众数
            //初始化
            int mode = nums[0];
            int votes = 0;
            //遍历找数
            for (int i = 0; i < nums.Length; i++)
            {
                if (votes == 0)
                {
                    mode = nums[i];
                }
                if (nums[i] == mode) 
                {
                    votes++;
                }
                else
                {
                    votes--;
                }
            }
            return mode;
        }
    }
}
