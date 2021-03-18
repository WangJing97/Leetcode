using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _563_二叉树的坡度
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        int sum = 0;
        public int FindTilt(TreeNode root)
        {
            Helper(root);
            return sum;
        }
        int Helper(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return root.val;

            int left = Helper(root.left);
            int right = Helper(root.right);

            sum += Math.Abs(left - right);

            return left + right + root.val;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
