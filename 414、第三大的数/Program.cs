using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _414_第三大的数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {2,2,3,1 };
            int res = ThirdMax(nums);
        }
        public static int ThirdMax(int[] nums)
        {
            long firstMax = long.MinValue;
            long secondMax = long.MinValue;
            long thirdMax = long.MinValue;

            foreach (int num in nums)
            {
                if (num.Equals(firstMax) || num.Equals(secondMax) || num.Equals(thirdMax))
                {
                    continue;
                }
                if (num > firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = num;
                }
                else if (num > secondMax && num < firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = num;
                }
                else if (num > thirdMax && num < secondMax) 
                {
                    thirdMax = num;
                }
            }
            if (thirdMax == long.MinValue)
            {
                return (int)firstMax;
            }
            return (int)thirdMax;
        }
    }
}
