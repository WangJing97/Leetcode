using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _448_找到所有数组中消失的数字
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            //可以采用 用数组的索引对应的数值是否出现过 做个标记：加个负号
            //4,3,2,7,8,2,3,1
            //比如4 对应的3位2加个负号 4，3，-2，7，8，2，3，1
            //3 对于2位3加个负号4，-3，-2，7，8，2，3，1
            //以此类推1，6，7，1，2，0除了已经变成负号的这组数字就变成了
            //-4，-3，-2，-7，8，2，-3，-1
            //只有8和2没有负号就说明他们对于十五索引没有出现5 6
            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) 
                {
                    nums[index] = -nums[index];
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) 
                {
                    result.Add(i + 1);
                }
            }
            return result;
        }
    }
}
