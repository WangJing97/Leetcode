# 101、对称二叉树（Symmetric Tree）

## 题目：

给定一个二叉树，检查它是否是镜像对称的。

 

例如，二叉树 `[1,2,2,3,4,4,3]` 是对称的。

```csharp
    1
   / \
  2   2
 / \ / \
3  4 4  3
```

 

但是下面这个 `[1,2,2,null,3,null,3]` 则不是镜像对称的:

```csharp
    1
   / \
  2   2
   \   \
   3    3
```

 

**进阶：**

你可以运用递归和迭代两种方法解决这个问题吗？

## 解答：

```csharp
public bool IsSymmetric(TreeNode root)
{
    if (root == null)
    {
        return true;
    }
    return helper(root.left, root.right);
}
public bool helper(TreeNode left, TreeNode right)
{
    //递归 看一个 和100题的方法类似
    if (left == null && right == null) 
    {
        return true;
    }
    if (left == null || right == null)
    {
        return false;
    }
    if (left.val != right.val) 
    {
        return false;
    }
    return helper(left.left, right.right) && helper(left.right, right.left);
}
```

