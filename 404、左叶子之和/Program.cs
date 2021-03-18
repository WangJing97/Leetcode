using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404_左叶子之和
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int SumOfLeftLeaves(TreeNode root)
        {
            //要注意是左叶子，不是左侧节点，左叶子：如果左节点不为空，且左节点没有左右孩子，那么这个节点就是左叶子
            if (root == null) 
            {
                return 0;
            }
            int sum = 0;
            if (root.left != null) 
            {
                if (root.left.left == null && root.left.right == null)
                {
                    sum += root.left.val;
                }
                else
                {
                    //检查下一个
                    sum += SumOfLeftLeaves(root.left);
                }
            }
            if (root.right != null) 
            {
                if (root.right.left != null || root.right.right != null) 
                {
                    sum += SumOfLeftLeaves(root.right);
                }
            }
            return sum;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
