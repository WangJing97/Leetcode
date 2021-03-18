using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _257_二叉树的所有路径
{
    class Program
    {
        static void Main(string[] args)
        {      
        }
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> res = new List<string>();
            DFS(res, root, "");
            return res;
        }
        //使用递归
        void DFS(List<string> res, TreeNode root, string path)
        {
            if (root == null) 
            {
                return;
            }
            path += Convert.ToString(root.val);
            DFS(res, root.left, path + "->");
            DFS(res, root.right, path + "->");
            if (root.left == null && root.right == null) 
            {
                res.Add(path);
            }
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
