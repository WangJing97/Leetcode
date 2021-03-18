using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,4,5,9,11 };
            int target = 8;
            int res = SearchInsert1(nums, target);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right) 
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target) 
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        public static int SearchInsert1(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int left = 0;
            int right = nums.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            if (nums[left] >= target)
            {
                return left;
            }
            else if (nums[left] < target && target <= nums[right])
            {
                return right;
            }
            else
            {
                return nums.Length;
            }
        }
    }

}
