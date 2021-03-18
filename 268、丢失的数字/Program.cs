using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _268_丢失的数字
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int MissingNumber(int[] nums)
        {
            //利用排序
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                //如果对不上就返回i
                if (nums[i] != i) 
                {
                    return i;
                }
            }
            return nums.Length;
        }
        public int MissingNumber1(int[] nums)
        {
            //也可以使用哈希表
            HashSet<int> hs = new HashSet<int>();
            foreach (int item in nums)
            {
                hs.Add(item);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(i)) 
                {
                    return i;
                }
            }
            return nums.Length;
        }
        public int MissingNumber2(int[] nums)
        {
            //数组所有数加起来和真实的比较就行
            int len = nums.Length;
            int sum = 0;
            foreach (int item in nums)
            {
                sum += item;
            }
            int total = len * (len + 1) / 2;
            return total - sum;
        }

    }
}
