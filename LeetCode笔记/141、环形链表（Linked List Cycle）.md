# 141、环形链表（Linked List Cycle）

## 题目：

给定一个链表，判断链表中是否有环。

如果链表中有某个节点，可以通过连续跟踪 `next` 指针再次到达，则链表中存在环。 为了表示给定链表中的环，我们使用整数 `pos` 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 `pos` 是 `-1`，则在该链表中没有环。**注意：`pos` 不作为参数进行传递**，仅仅是为了标识链表的实际情况。

如果链表中存在环，则返回 `true` 。 否则，返回 `false` 。

 

**进阶：**

你能用 *O(1)*（即，常量）内存解决此问题吗？

 

**示例 1：**

![img](141%E3%80%81%E7%8E%AF%E5%BD%A2%E9%93%BE%E8%A1%A8%EF%BC%88Linked%20List%20Cycle%EF%BC%89.assets/circularlinkedlist.png)

```csharp
输入：head = [3,2,0,-4], pos = 1
输出：true
解释：链表中有一个环，其尾部连接到第二个节点。
```

**示例 2：**

![img](141%E3%80%81%E7%8E%AF%E5%BD%A2%E9%93%BE%E8%A1%A8%EF%BC%88Linked%20List%20Cycle%EF%BC%89.assets/circularlinkedlist_test2.png)

```csharp
输入：head = [1,2], pos = 0
输出：true
解释：链表中有一个环，其尾部连接到第一个节点。
```

**示例 3：**

![img](141%E3%80%81%E7%8E%AF%E5%BD%A2%E9%93%BE%E8%A1%A8%EF%BC%88Linked%20List%20Cycle%EF%BC%89.assets/circularlinkedlist_test3.png)

```csharp
输入：head = [1], pos = -1
输出：false
解释：链表中没有环。
```

 

**提示：**

- 链表中节点的数目范围是 `[0, 104]`
- `-105 <= Node.val <= 105`
- `pos` 为 `-1` 或者链表中的一个 **有效索引** 。

## 解答：

法一：Hash表

```csharp
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
```

法二：Hash表2

```csharp
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
```

法三：快慢指针

```csharp
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
```

