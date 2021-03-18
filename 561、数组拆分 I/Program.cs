using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _561_数组拆分_I
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int ArrayPairSum(int[] nums)
        {
            //证明？
            //排序，隔两个取就是所得
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2) 
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
