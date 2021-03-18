using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _228_汇总区间
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 2, 3, 4, 6, 8, 9 };
            List<string> res = new List<string>();
            res = SummaryRanges(nums);
            Console.ReadKey();
        }

        public static IList<string> SummaryRanges(int[] nums)
        {
            List<string> res = new List<string>();
            if (nums == null || nums.Length == 0) 
            {
                return res;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                while (i < nums.Length - 1 && nums[i] + 1 == nums[i + 1]) 
                {
                    i++;
                }

                //是一个范围
                if (num != nums[i]) 
                {
                    res.Add(num + "->" + nums[i]);
                }
                //是一个数字
                else
                {
                    res.Add(nums[i].ToString());
                }
            }
            return res;
        }
    }
}
