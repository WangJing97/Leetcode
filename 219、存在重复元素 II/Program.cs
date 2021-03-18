using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219_存在重复元素_II
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //解题，利用字典
        //key装数组，value装序号
        //用i往后
        //如果字典里没有这个key
        //就把这个序号i放里边
        //如果字典里已经包含了key就进入判断
        //如果这时的i小于当前到的（<=符合要求的）
        //返回正确
        //不符合的就把当前的序号i更新他
        //最后都不符合的就返回失败
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i])) 
                {
                    dic[nums[i]] = i;
                }
                else
                {
                    if (i - dic[nums[i]] <= k)  
                    {
                        return true;
                    }
                    else
                    {
                        dic[nums[i]] = i;
                    }
                }
            }
            return false;
        }
    }
}
