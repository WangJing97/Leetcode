# 112、路径总和（Path Sum）

## 题目：

给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。

**说明:** 叶子节点是指没有子节点的节点。

**示例:** 
给定如下二叉树，以及目标和 `sum = 22`，

```csharp
              5
             / \
            4   8
           /   / \
          11  13  4
         /  \      \
        7    2      1
```

返回 `true`, 因为存在目标和为 22 的根节点到叶子节点的路径 `5->4->11->2`。

## 解答：

```csharp
public bool HasPathSum(TreeNode root, int sum)
{
    if (root == null)
    {
        return false;
    }
    if (root.left == null && root.right == null)  
    {
        return root.val == sum;
    }
    return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
}
/*
    *      sum = 22    
    *         5                 5                       5 >22（要求）
    *        / \               / \                      /  \  
    *       4   8       22-5=17? 22-5=17?            4 >17  8 >17
    *      /   / \                                    /  
    *     11  13  4                                11 >13   
    *    /  \      \                              /      \
    *   7    2      1                           7 >2    2 >2
    *                                     (条件2)false   true
    *      1、null  return
    *      2、left = null,right = null 
    *               val ?= sum  
    *
    */
```

