using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _645_错误的集合
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int[] FindErrorNums(int[] nums)
        {
            //先排序，相等的数字就是连续的，检查相邻的数字是否相差1即可
            Array.Sort(nums);
            int miss = 1, mistake = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                //如果相等就是错误的数字
                if (nums[i] == nums[i - 1])
                {
                    mistake = nums[i];
                }
                //如果这个数字比前一个大，就是丢掉的数
                else if (nums[i] > nums[i - 1] + 1) 
                {
                    miss = nums[i - 1] + 1;
                }
            }
            //输出的是否需要注意，两个相同的数字的数组会出错，例如[1,1]输出的结果就是[1,-1]，需要做判断
            if (nums[nums.Length - 1] != nums.Length)
            {
                miss = nums.Length;
            }
            return new int[] { mistake, miss };
        }

        public int[] FindErrorNums1(int[] nums)
        {
            //使用字典即可统计出每个数字出现的时间
            Dictionary<int, int> dic = new Dictionary<int, int>(0);

            int miss = 1, mistake = -1;
            foreach (int item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }
                dic[item]++;
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (dic.ContainsKey(i)) 
                {
                    //重复的就是错误的数字
                    if (dic[i] == 2) 
                    {
                        mistake = i;
                    }
                }
                else
                {
                    miss = i;
                }
            }
            return new int[] { mistake, miss };
        }

    }
}
