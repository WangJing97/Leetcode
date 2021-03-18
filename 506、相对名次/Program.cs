using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _506_相对名次
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string[] FindRelativeRanks(int[] nums)
        {
            //首先用字典记录每个元素对应的值
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }
            //排序
            Array.Sort(nums);
            string[] result = new string[nums.Length];
            //遍历排好的数组
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                //先确定 1 2 3名的顺序，通过字典的索引来进行赋值
                switch (nums.Length - i)
                {
                    case 1:
                        result[dic[nums[i]]] = "Gold Medal";
                        break;
                    case 2:
                        result[dic[nums[i]]] = "Silver Medal";
                        break;
                    case 3:
                        result[dic[nums[i]]] = "Bronze Medal";
                        break;
                    default:
                        result[dic[nums[i]]] = (nums.Length - i).ToString();
                        break;
                }
            }
            return result;
        }
    }
}
