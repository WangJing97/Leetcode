using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206_反转链表
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //双指针
        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            ListNode tmp = null;
            while (cur != null) 
            {
                tmp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = tmp;
            }
            return pre;
        }
        //递归 注意理解
        public ListNode ReverseList1(ListNode head)
        {
            //退出条件
            if (head == null || head.next == null) 
            {
                return head;
            }
            ListNode cur = ReverseList1(head.next);
            //拼接处理
            head.next.next = head;
            head.next = null;
            return cur;
        }

    }
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
