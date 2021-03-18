using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112_路径总和
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)  
            {
                return root.val == sum;
            }
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
        /*
         *      sum = 22    
         *         5                 5                       5 >22（要求）
         *        / \               / \                      /  \  
         *       4   8       22-5=17? 22-5=17?            4 >17  8 >17
         *      /   / \                                    /  
         *     11  13  4                                11 >13   
         *    /  \      \                              /      \
         *   7    2      1                           7 >2    2 >2
         *                                     (条件2)false   true
         *      1、null  return
         *      2、left = null,right = null 
         *               val ?= sum  
         *
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
