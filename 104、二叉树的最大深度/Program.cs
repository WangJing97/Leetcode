using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_二叉树的最大深度
{
    class Program
    {
        static void Main(string[] args)
        {
        }
public int MaxDepth(TreeNode root)
{
    //递归
    //最大的其实是一个左子树和右子树最大的那个，重复
    //如果一个是空 返回0
    if (root == null) 
    {
        return 0;
    }
    return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
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
