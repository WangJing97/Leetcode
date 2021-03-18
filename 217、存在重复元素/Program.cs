using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_存在重复元素
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //简单的遍历 但是会超时
        public bool ContainsDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] == nums[j]) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //利用HashSet的特性 添加重复的会返回fasle
        public bool ContainsDuplicate1(int[] nums)
        {
            if (nums == null || nums.Length <= 1)  
            {
                return false;
            }
            HashSet<int> HS = new HashSet<int>();
            foreach (int item in nums)
            {
                if (!HS.Add(item))
                {
                    return true;
                }
            }
            return false;
        }
        //先排序 一前一后比较
        public bool ContainsDuplicate2(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return false;
            }
            Array.Sort(nums);
            int pre = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == pre) 
                {
                    return true;
                }
                else
                {
                    pre = nums[i];
                }
            }
            return false;
        }

    }
}
