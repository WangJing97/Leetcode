# 237、删除链表中的节点（Delete Node in a Linked List）

## 题目：

请编写一个函数，使其可以删除某个链表中给定的（非末尾）节点。传入函数的唯一参数为 **要被删除的节点** 。

现有一个链表 -- head = [4,5,1,9]，它可以表示为:

![img](https://assets.leetcode-cn.com/aliyun-lc-upload/uploads/2019/01/19/237_example.png)

**示例 1:**

![img](D:\PC\LeetCode\237、删除链表中的节点（Delete Node in a Linked List）.assets\node1.jpg)

```
输入: head = [4,5,1,9], node = 5
输出: [4,1,9]
解释: You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.
```

**示例 2:**

![img](D:\PC\LeetCode\237、删除链表中的节点（Delete Node in a Linked List）.assets\node2.jpg)

```
输入: head = [4,5,1,9], node = 1
输出: [4,5,9]
解释: You are given the third node with value 1, the linked list should become 4 -> 5 -> 9 after calling your function.
```

**示例 3:**

```
输入: head = [1,2,3,4], node = 3
输出: [1,2,4]
```

**示例 4:**

```
输入: head = [0,1], node = 0
输出: [1]
```

**示例 5:**

```
输入: head = [-3,5,-99], node = -3
输出: [5,-99]
```

 

**提示：**

- 链表至少包含两个节点。
- 链表中所有节点的值都是唯一的。
- 给定的节点为非末尾节点并且一定是链表中的一个有效节点。
- 不要从你的函数中返回任何结果。

## 解答：

```csharp
public void DeleteNode(ListNode node)
{
    //删掉要的节点 只需要把后一个数给这个数 然后把next连到下下个上面去
    node.val = node.next.val;
    node.next = node.next.next;
}
```

