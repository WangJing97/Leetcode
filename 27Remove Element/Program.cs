using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Remove_Element
{
    class Program
    {
        //给你一个数组 nums 和一个值 val，你需要 原地 移除所有数值等于 val 的元素，并返回移除后数组的新长度
        //不要使用额外的数组空间，你必须仅使用 O(1) 额外空间并 原地 修改输入数组。
        //元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。

        //示例：
        //给定 nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2,
        //函数应该返回新的长度 5, 并且 nums 中的前五个元素为 0, 1, 3, 0, 4。
        //注意这五个元素可为任意顺序。
        //你不需要考虑数组中超出新长度后面的元素。
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int res = RemoveElement(nums, val);
            Console.WriteLine(res);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
        public static int RemoveElement(int[] nums, int val)
        {
            //过程：和上题类似p前面的是整理好的数字，第一步i和p都指向第一个数0，i这时指向的不是目标数2，
            //就把i的值赋值给p，接着p往后移，也就是说p点是有可能要更新的位置（也是第一个无效的位置），i也接着往后移，
            //i现在指向1，还是不等于2，继续把值赋给p并且往后移，接着i继续向后走指向2这时等于目标数，这时p不动，i继续移动
            //直到3时，与目标数不一样，就把值赋给p值并且给p赋值
            if (nums == null || nums.Length == 0) 
            {
                return 0;
            }
            int p = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[p] = nums[i];
                    p++;
                }
            }
            return p;
        }
    }
}
