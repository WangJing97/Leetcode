using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501_二叉搜索树中的众数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        TreeNode prve;
        int count = 0;
        int count_max = 0;
        List<int> modes = new List<int>();

        public int[] FindMode(TreeNode root)
        {
            if (root == null) return new int[0];
            //递归遍历
            FindMode_helper(root);

            return modes.ToArray();
        }
        public void FindMode_helper(TreeNode node)
        {
            //这种遍历方法叫做中序遍历，他会把树里边的数字按照顺序打印出来（要是二叉搜索树）
            //根节点的值大于其左子树中任意一个节点的值，小于其右节点中任意一节点的值，
            if (node == null) return;

            FindMode_helper(node.left);
            //放在中间
            if (prve == null)
            {
                //这是比较的第一个元素
                prve = node;
                count = 1;
            }
            else
            {
                if (prve.val == node.val)
                {
                    count++;
                }
                else if (prve.val != node.val)
                {
                    prve = node;
                    count = 1;
                }
            }
            //modes来存每个答案
            if (count > count_max)
            {
                count_max = count;

                modes.Clear();
                modes.Add(node.val);
            }
            //相同一样的
            else if (count == count_max)
            {
                modes.Add(node.val);
            }
            else if (count < count_max)
            {
                //不用操作
            }

            FindMode_helper(node.right);
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
