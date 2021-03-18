using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _543_二叉树的直径
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        int result;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            DFS(root);
            return result;
        }
        private int DFS(TreeNode node)
        {
            
            //老方法，遍历然后根据返回的数字进行比较大小

            if (node == null) return 0;

            int left = DFS(node.left);
            int right = DFS(node.right);

            result = Math.Max(result, left + right);
            return Math.Max(left, right) + 1;
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
