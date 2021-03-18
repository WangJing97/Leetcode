using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _203_移除链表元素
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) 
            {
                return head;
            }
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            ListNode p = dummy;

            while (p.next != null) 
            {
                if (p.next.val == val) 
                {
                    p.next = p.next.next;
                }
                else
                {
                    p = p.next;
                }
            }
            return dummy.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
