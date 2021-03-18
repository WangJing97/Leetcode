# 100、相同的树（Same Tree）

## 题目：

给定两个二叉树，编写一个函数来检验它们是否相同。

如果两个树在结构上相同，并且节点具有相同的值，则认为它们是相同的。

**示例 1:**

```csharp
输入:       1         1
          / \       / \
         2   3     2   3

        [1,2,3],   [1,2,3]
    
输出: true
```

**示例 2:**

```csharp
输入:      1          1
          /           \
         2             2

        [1,2],     [1,null,2]

输出: false
```

**示例 3:**

```csharp
输入:       1         1
          / \       / \
         2   1     1   2

        [1,2,1],   [1,1,2]

输出: false
```

## 解答：

```csharp
public bool IsSameTree(TreeNode p, TreeNode q)
{
    //递归
    if (p == null && q == null) 
    {
        return true;
    }
    else if (p == null || q == null)
    {
        return false;
    }
    else
    {
        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
```

