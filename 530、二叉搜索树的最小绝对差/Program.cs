using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _530_二叉搜索树的最小绝对差
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int GetMinimumDifference(TreeNode root)
        {
            //501、二叉搜索树中的众数中的中序遍历，在加上一个集合，就可以把这些数字按照顺序加到列表里边，最后计算一下差值
            List<int> list = new List<int>();
            inorder(root, list);
            int min = int.MaxValue;
            for (int i = 1; i < list.Count; i++)
            {
                min = Math.Min(min, list[i] - list[i - 1]);
            }
            return min;
        }
        private static void inorder(TreeNode root, List<int> list)
        {
            if (root == null) return;
            inorder(root.left, list);
            list.Add(root.val);
            inorder(root.right, list);
        }

        int prev = -1;
        int min = 0;
        
        public int GetMinimumDifference1(TreeNode root)
        {
            //也可以只记住前一个节点的数值，因为只要找到两个相减最小的就行
            min = int.MaxValue;
            inorder1(root);
            return min;
        }

        private void inorder1(TreeNode root)
        {
            if (root == null) { return; }
            inorder1(root.left);
            if (prev != -1) min = Math.Min(min, root.val - prev);
            prev = root.val;
            inorder1(root.right);
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
