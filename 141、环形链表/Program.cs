using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141_环形链表
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> node = new HashSet<ListNode>();
            while (head != null)
            {
                if (node.Contains(head)) 
                {
                    return true;
                }
                else
                {
                    node.Add(head);
                }
                head = head.next;
            }
            return false;
        }
        public bool HasCycle1(ListNode head)
        {
            //学习思路
            //通过使用具不同速度的快、慢两个指针遍历链表，慢指针每次移动一步，而快指针每次移动两步。
            //降低复杂度
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }
        public bool HasCycle2(ListNode head)
        {
            HashSet<ListNode> hashset = new HashSet<ListNode>();
            while (head != null)
            {
                if (hashset.Add(head) == false)
                {
                    return true;
                }

                head = head.next;
            }
            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
