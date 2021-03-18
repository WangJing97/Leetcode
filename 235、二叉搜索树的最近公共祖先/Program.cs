using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _235_二叉搜索树的最近公共祖先
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        /*
        利用 二叉搜索树 的性质：
        左 > 根 > 右
        利用这个性质可以推断出p q与root的关系
        若 root.val < p.val ，则 p 在 root 右子树 中；
        若 root.val > p.val ，则 p 在 root 左子树 中；
        若 root.val = p.val ，则 p 和 root 指向 同一节点 。
        第一种方法 迭代
        当 p, q 都在 root 的 右子树 中，则遍历至 root.right ；
        否则，当 p, q 都在 root 的 左子树 中，则遍历至 root.left ；
        否则，说明找到了 最近公共祖先 ，跳出。
        第二种方法 递归
        看图
        */
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while (root != null) 
            {
                //p，q都在root的右子树中
                if (root.val < p.val && root.val < q.val)
                {
                    //遍历右子节点
                    root = root.right;
                }
                //p，q都在root的左子树中
                else if (root.val > p.val && root.val > q.val)
                {
                    //遍历左子节点
                    root = root.left;
                }
                else break;
            }
            return root;
        }

        public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }
            if (root == p || root == q) 
            {
                return root;
            }
            TreeNode left = LowestCommonAncestor1(root.left, p, q);
            TreeNode right = LowestCommonAncestor1(root.right, p, q);
            if (left != null && right != null) 
            {
                return root;
            }
            if (left == null && right == null) 
            {
                return null;
            }
            return left != null ? left : right;
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
