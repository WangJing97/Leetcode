using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _453_最小操作次数使数组元素相等
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int MinMoves(int[] nums)
        {
            /*
            原题目n-1个数字之外都减一，等于这个数字加一
            123
            122
            121
            111
            只关心步数，所以每个数都减去最小的数字，计算步数就行
            */
            int result = 0;
            int minNumber = nums.Min();
            foreach (int num in nums)
            {
                result += num - minNumber;
            }
            return result;
        }
    }
}
