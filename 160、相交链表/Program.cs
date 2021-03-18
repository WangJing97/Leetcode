using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160_相交链表
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        /*
        1——1——1\
         2——2——3——3——3
         两个指针走完自己的路以后再走对方的路
         1、a+c+b
         2、b+c+a
         如果有共同的点两个指针就会相遇
         */
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) 
            {
                return null;
            }
            ListNode a = headA;
            ListNode b = headB;
            while (a != b)
            {
                if (a == null)
                {
                    a = headB;
                }
                else
                {
                    a = a.next;
                }
                if (b == null) 
                {
                    b = headA;
                }
                else
                {
                    b = b.next;
                }
            }
            return a;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
