# 404、左叶子之和（Sum of Left Leaves）

## 题目：

计算给定二叉树的所有左叶子之和。

**示例：**

```
    3
   / \
  9  20
    /  \
   15   7

在这个二叉树中，有两个左叶子，分别是 9 和 15，所以返回 24
```

 

## 解答：

法一：

```csharp
public int SumOfLeftLeaves(TreeNode root)
{
    //要注意是左叶子，不是左侧节点，左叶子：如果左节点不为空，且左节点没有左右孩子，那么这个节点就是左叶子
    if (root == null) 
    {
        return 0;
    }
    int sum = 0;
    if (root.left != null) 
    {
        if (root.left.left == null && root.left.right == null)
        {
            sum += root.left.val;
        }
        else
        {
            //检查下一个
            sum += SumOfLeftLeaves(root.left);
        }
    }
    if (root.right != null) 
    {
        if (root.right.left != null || root.right.right != null) 
        {
            sum += SumOfLeftLeaves(root.right);
        }
    }
    return sum;
}
```

