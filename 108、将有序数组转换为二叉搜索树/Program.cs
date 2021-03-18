using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_将有序数组转换为二叉搜索树
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0) 
            {
                return null;
            }
            TreeNode root = helper(nums, 0, nums.Length - 1);
            return root;
        }
        public TreeNode helper(int[] nums, int low, int high)
        {
            //把中间的提起来。左边的小一点
            if (low > high) 
            {
                return null;
            }
            //这样可以防止泄露，不推荐(low+high)/2
            int mid = low + (high - low) / 2;
            //把新的mid作为root
            TreeNode node = new TreeNode(nums[mid]);
            node.left = helper(nums, low, mid - 1);
            node.right = helper(nums, mid + 1, high);
            return node;
        }
    }
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
