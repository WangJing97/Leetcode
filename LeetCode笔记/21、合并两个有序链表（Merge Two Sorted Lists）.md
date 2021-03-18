# 21、合并两个有序链表（Merge Two Sorted Lists）

## 题目：

将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

**示例：**

**输入：**1->2->4, 1->3->4

**输出：**1->1->2->3->4->4

## 解答：

```csharp
class Program
{
    static void Main(string[] args)
    {
    }
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        ListNode cur = dummy;

        //当两个链表不是空的时候开始循环
        while (l1 != null && l2 != null)
        {
            //如果第一个链表中的数字比第二个小就把当前的指针移到l1上
            if (l1.val <= l2.val)
            {
                //把cur节点连到l1上去
                cur.next = l1;
                //同时把l1和cur的指针向后移动一个
                l1 = l1.next;
                cur = cur.next;
            }
            //如果第一个链表中的数字比第二个大就把当前的指针移到l2上
            //也就是把小的先放在cur上
            else
            {
                //与上面类似
                cur.next = l2;
                l2 = l2.next;
                cur = cur.next;
            }
        }
        if (l1 == null)
        {
            //如果单是l1是空的话，就把cur交给不是空的那个
            cur.next= l2;
        }
        if (l2 == null)
        {
            //如果单是l1是空的话，就把cur交给不是空的那个
            cur.next = l1;
        }
        return dummy.next;
    }
}

//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
```

