using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234_回文链表
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) 
            {
                return true;
            }
            List<int> list = new List<int>();
            while (head != null) 
            {
                list.Add(head.val);
                head = head.next;
            }
            int l = 0;
            int r = list.Count - 1;
            while (l < r) 
            {
                if (list[l] != list[r]) 
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
        ListNode p;
        public bool IsPalindrome1(ListNode head)
        {
            p = head;
            return recursion(head);
        }
        private bool recursion(ListNode head)
        {
            if (head == null) 
            {
                return true;
            }
            if (!recursion(head.next)) 
            {
                return false;
            }
            if (p.val != head.val) 
            {
                return false;
            }
            p = p.next;
            return true;
        }
        public bool IsPalindrome2(ListNode head)
        {
            if (head == null || head.next == null) 
            {
                return true;
            }
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null) 
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            //奇数情况
            if (fast != null) 
            {
                slow = slow.next;
            }
            //快指针到最前面
            fast = head;
            //反转slow之后的链表
            //现在的头就是reversedList了
            ListNode reversedList = reverselist(slow);
            //比较
            while (reversedList != null) 
            {
                if (fast.val != reversedList.val)
                {
                    return false;
                }
                fast = fast.next;
                reversedList = reversedList.next;
            }
            return true;
        }
        //反转链表206方法挑一个
        private ListNode reverselist(ListNode head)
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

        //利用栈
        public bool IsPalindrome3(ListNode head)
        {
            if (head == null || head.next == null) 
            {
                return true;
            }
            ListNode temp = head;
            Stack<int> stack = new Stack<int>();
            while (temp != null)
            {
                stack.Push(temp.val);
                temp = temp.next;
            }
            while (head != null && stack.Count != 0) 
            {
                if (head.val != stack.Pop()) 
                {
                    return false;
                }
                head = head.next;
            }
            return true;
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
