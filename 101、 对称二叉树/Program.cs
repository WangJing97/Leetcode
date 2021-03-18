using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101__对称二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return helper(root.left, root.right);
        }
        public bool helper(TreeNode left, TreeNode right)
        {
            //递归 看一个 和100题的方法类似
            if (left == null && right == null) 
            {
                return true;
            }
            if (left == null || right == null)
            {
                return false;
            }
            if (left.val != right.val) 
            {
                return false;
            }
            return helper(left.left, right.right) && helper(left.right, right.left);
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
