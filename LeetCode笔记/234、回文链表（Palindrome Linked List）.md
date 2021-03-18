# 234、回文链表（Palindrome Linked List）

## 题目：

请判断一个链表是否为回文链表。

**示例 1:**

```
输入: 1->2
输出: false
```

**示例 2:**

```
输入: 1->2->2->1
输出: true
```

**进阶：**
你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？

解答：![Screenshot_20201125_103617_com.newskyer.draw_edit](D:\PC\LeetCode\234、回文链表（Palindrome Linked List）.assets\Screenshot_20201125_103617_com.newskyer.draw_edit.jpg)



![Screenshot_20201125_103728_com.newskyer.draw_edit](D:\PC\LeetCode\234、回文链表（Palindrome Linked List）.assets\Screenshot_20201125_103728_com.newskyer.draw_edit-1606273745353.jpg)

![9](D:\PC\LeetCode\234、回文链表（Palindrome Linked List）.assets\9.jpg)

法一（转成数组）：

```csharp
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
```

法二（递归）：

```csharp
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
```

法三（快慢指针）：

```csharp
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
```

法四（栈）：

```csharp
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
```

