using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_平衡二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) 
            {
                return true;
            }
            return IsBalanced(root.left) && IsBalanced(root.right) && (Math.Abs(height(root.left) - height(root.right)) <= 1);
        }
        public int height(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }
            return Math.Max(height(root.left), height(root.right)) + 1;
        }
        /*            如何获取高度
         *          1           4 > -1 > 0
         *         / \              -1
         *        2   2
         *       / \            3 > 0 > 1
         *      3   3               0
         *     / \
         *    4   4             2 > 1 > 2
         *                          0 
         *    注意：要考虑不是每个都是这样的工整，有缺的，要都考虑
        */
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
