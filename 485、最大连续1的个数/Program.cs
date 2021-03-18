using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _485_最大连续1的个数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            //是1就加，不是就设为0
            int result = 0;
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) 
                {
                    current += 1;
                    result = Math.Max(result, current);
                }
                else
                {
                    current = 0;
                }
            }
            return result;
        }
    }
}
