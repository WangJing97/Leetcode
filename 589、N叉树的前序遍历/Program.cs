using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _589_N叉树的前序遍历
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public IList<int> Preorder(Node root)
        {
            //遍历每个节点，并且把每个子节放到结果的list中
            List<int> list = new List<int>();
            return helper(root, list);
        }
        public List<int>helper(Node root, List<int> list)
        {
            if (root == null) return list;
            list.Add(root.val);
            foreach (Node child in root.children)
            {
                helper(child, list);
            }
            return list;
        }


        public IList<int> Preorder1(Node root)
        {
            //通过栈的特性先进后去，把节点放进去之后在放进list
            Stack<Node> stack = new Stack<Node>();
            List<int> list = new List<int>();
            if (root == null) return list;
            stack.Push(root);

            while (stack.Count != 0) 
            {
                Node node = stack.Pop();
                list.Add(node.val);
                for (int i = node.children.Count - 1; i >= 0; i--) 
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
