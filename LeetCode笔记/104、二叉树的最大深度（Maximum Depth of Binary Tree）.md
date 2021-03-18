# 104、二叉树的最大深度（Maximum Depth of Binary Tree）

## 题目：

给定一个二叉树，找出其最大深度。

二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

**说明:** 叶子节点是指没有子节点的节点。

**示例：**
给定二叉树 `[3,9,20,null,null,15,7]`，

```csharp
    3
   / \
  9  20
    /  \
   15   7
```

返回它的最大深度 3 。

## 解答：

```csharp
public int MaxDepth(TreeNode root)
{
    //递归
    //最大的其实是一个左子树和右子树最大的那个，重复
    //如果一个是空 返回0
    if (root == null) 
    {
        return 0;
    }
    return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
}
```

