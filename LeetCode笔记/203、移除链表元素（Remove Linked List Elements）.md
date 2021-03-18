# 203、移除链表元素（Remove Linked List Elements）

## 题目：

删除链表中等于给定值 **val** 的所有节点。

**示例:**

```
输入: 1->2->6->3->4->5->6, val = 6
输出: 1->2->3->4->5
```

## 解答：![Screenshot_20201127_212723](D:\PC\LeetCode\203、移除链表元素（Remove Linked List Elements）.assets\Screenshot_20201127_212723.jpg)

```csharp
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
```

