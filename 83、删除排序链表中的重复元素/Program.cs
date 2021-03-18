using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_删除排序链表中的重复元素
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode ls = new ListNode(0);
            ls.next = head;
            ListNode p = ls;

            while (p.next != null && p.next.next != null)
            {
                //相等的连上
                if (p.next.val == p.next.next.val) 
                {
                    p.next = p.next.next;
                }
                //不相等的找下一个
                else
                {
                    p = p.next;
                }
            }
            return ls.next;
        }
    }




    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
