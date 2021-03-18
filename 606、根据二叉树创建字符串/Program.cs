using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _606_根据二叉树创建字符串
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string Tree2str(TreeNode t)
        {
            //根据题意进行拼接
            if (t == null) 
            {
                return "";
            }
            if (t.left == null && t.right == null) 
            {
                return t.val + "";
            }
            if (t.left == null) 
            {
                return t.val + "()" + "(" + Tree2str(t.right) + ")";
            }
            if (t.right == null) 
            {
                return t.val + "(" + Tree2str(t.left) + ")";
            }
            return t.val + "(" + Tree2str(t.left) + ")" + "(" + Tree2str(t.right) + ")";

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
