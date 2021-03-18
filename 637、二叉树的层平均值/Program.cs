using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _637_二叉树的层平均值
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> result = new List<double>();
            if (root == null) 
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            double level_sum = 0;
            while (queue.Count != 0) 
            {
                level_sum = 0;

                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current_node = queue.Dequeue();

                    level_sum += current_node.val;
                    if (current_node.left != null) 
                    {
                        queue.Enqueue(current_node.left);
                    }
                    if (current_node.right != null)
                    {
                        queue.Enqueue(current_node.right);
                    }
                }
                double level_avg = level_sum / size;

                result.Add(level_avg);
            }
            return result;
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
