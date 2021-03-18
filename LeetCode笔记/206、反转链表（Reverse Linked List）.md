# 206、反转链表（Reverse Linked List）

## 题目：

反转一个单链表。

**示例:**

```
输入: 1->2->3->4->5->NULL
输出: 5->4->3->2->1->NULL
```

**进阶:**
你可以迭代或递归地反转链表。你能否用两种方法解决这道题？

## 解答：

![](D:\PC\LeetCode\206、反转链表（Reverse Linked List）.assets\Screenshot_20201125_184048_com.newskyer.draw_edit.jpg)

![Screenshot_20201125_184057_com.newskyer.draw_edit](D:\PC\LeetCode\206、反转链表（Reverse Linked List）.assets\Screenshot_20201125_184057_com.newskyer.draw_edit.jpg)

![Screenshot_20201125_184103_com.newskyer.draw_edit](D:\PC\LeetCode\206、反转链表（Reverse Linked List）.assets\Screenshot_20201125_184103_com.newskyer.draw_edit.jpg)

![Screenshot_20201125_184107_com.newskyer.draw](D:\PC\LeetCode\206、反转链表（Reverse Linked List）.assets\Screenshot_20201125_184107_com.newskyer.draw.jpg)

![Screenshot_20201125_184109_com.newskyer.draw](D:\PC\LeetCode\206、反转链表（Reverse Linked List）.assets\Screenshot_20201125_184109_com.newskyer.draw.jpg)

法一（双指针）：

```csharp
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
```

法二（迭代）：

```csharp
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
```

