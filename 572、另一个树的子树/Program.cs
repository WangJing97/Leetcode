using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _572_另一个树的子树
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            //思路：遍历每个子树
            //先访问节点，判断是否是相同的子树，如果不是继续下一个左右是一个||的关系
            //但是在对子树是否是相同中 就是&&两边必须都要满足
            if (s == null) return false;
            if (sameTree(s, t)) return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
        public bool sameTree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            //其中一个是空的画就不是正确的
            if (s == null || t == null) return false;
            return s.val == t.val && sameTree(s.left, t.left) && sameTree(s.right, t.right);
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
