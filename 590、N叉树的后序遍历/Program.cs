using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _590_N叉树的后序遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public IList<int> Postorder(Node root)
        {
            //和前序的方向不一样 5在第一个1在最后你
            List<int> list = new List<int>();
            return helper(root, list);
        }
        public List<int>helper(Node root, List<int> list)
        {
            if (root == null) return list;
            //和上题一样的遍历每个节点的子节点
            foreach (Node child in root.children)
            {
                helper(child, list);
            }
            list.Add(root.val);
            return list;
        }

        public IList<int> Postorder1(Node root)
        {
            //和前序思路差不多，用insert
            List<int> list = new List<int>();
            if (root == null) return list;
            Stack<Node> stack = new Stack<Node>();

            stack.Push(root);

            while (stack.Count != 0) 
            {
                Node node = stack.Pop();
                list.Insert(0, node.val);

                for (int i = 0; i < node.children.Count; i++)
                {
                    stack.Push(node.children[i]);
                }
            }
            return list;
        }

    }
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
