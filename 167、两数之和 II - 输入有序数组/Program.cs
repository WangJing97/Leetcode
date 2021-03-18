using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _167_两数之和_II___输入有序数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] res = new int[] { };
            res = TwoSum(numbers, target);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            //字典中没有目标时就会把数组中对应位置的数字给字典的Key，把序号给Value
            //如果找到了就返回数字的序号。
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsKey(target - numbers[i])) 
                {
                    return new int[] { dic[target - numbers[i]], i + 1 };
                }
                dic[numbers[i]] = i + 1;
            }
            return null;
        }
        public int[] TwoSum1(int[] numbers, int target)
        {
            //从头到尾的找，利用他已经排序的前提
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
            }
            return null;
        }
    }
}
