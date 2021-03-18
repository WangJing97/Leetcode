using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _237_删除链表中的节点
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void DeleteNode(ListNode node)
        {
            //删掉要的节点 只需要把后一个数给这个数 然后把next连到下下个上面去
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
