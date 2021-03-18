using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _575_分糖果
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int DistributeCandies(int[] candyType)
        {
            //首先进行排序操作，遍历这个数组，看看前一个和后一个是否相同，不相同的话说明不一样，就把计数变量++，来计算种类
            Array.Sort(candyType);
            int count = 1;
            for (int i = 1; i < candyType.Length && count < candyType.Length / 2; i++) 
            {
                if (candyType[i] > candyType[i - 1]) count++;
            }
            return count;
        }
        public int DistributeCandies1(int[] candyType)
        {
            //利用HashSet的特性加入的数字具有唯一性
            HashSet<int> set = new HashSet<int>();
            foreach (int candy in candyType)
            {
                set.Add(candy);
            }
            return Math.Min(set.Count, candyType.Length / 2);
        }
    }
}
