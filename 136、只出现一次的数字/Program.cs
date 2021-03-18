using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _136_只出现一次的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            int res = SingleNumber(nums);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int SingleNumber(int[] nums)
        {
            //如果我们对0和二进制数做异或计算，得到的数仍然是这个二进制数
            //如果我们对相同的二进制数做异或计算，得到的数则是0
            //同一个数做两次异或的结果0
            //所以相同的数就会被变成0
            for (int i = 1; i < nums.Length; i++)
            {
                //a = a^b
                nums[0] ^= nums[i];
            }
            return nums[0];
        }
        public int SingleNumber1(int[] nums)
        {
            //Hash表的add返回值是bool
            //如果该元素添加到 HashSet<T> 对象中则为true；如果该元素已存在则为 false。 
            HashSet<int> HS = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!HS.Add(nums[i])) 
                {
                    HS.Remove(nums[i]);
                }
            }
            return HS.First();
        }
        //public int MajorityElement(int[] nums)
        //{
        //    HashSet<int> HS = new HashSet<int>();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (HS.Add(nums[i]))
        //        {

        //        }
        //    }
        //}
    }
}
