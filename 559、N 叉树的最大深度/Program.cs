using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _559_N_叉树的最大深度
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int MaxDepth(Node root)
        {
            //宽度优先
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            int depth = 0;
            if (root == null) return 0;
            
            while (queue.Count != 0) 
            {
                //不能写在for里边 Queue会变化
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node currentNode = queue.Dequeue();
                    foreach (Node child in currentNode.children) 
                    {
                        if (child != null) queue.Enqueue(child);
                    }
                }
                depth++;
            }
            return depth;
        }

        int max_depth;
        public int MaxDepth1(Node root)
        {
            if (root == null) return 0;
            getMaxDepth(root, 1);
            return max_depth;
        }
        public void getMaxDepth(Node node, int depth)
        {
            //搜索到地就开始返回
            if (node == null) return;
            max_depth = Math.Max(depth, max_depth);
            foreach (Node child in node.children)
            {
                getMaxDepth(child, depth + 1);
            }
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
