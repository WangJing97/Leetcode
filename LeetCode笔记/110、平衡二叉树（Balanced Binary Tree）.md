# 110、平衡二叉树（Balanced Binary Tree）

## 题目：

给定一个二叉树，判断它是否是高度平衡的二叉树。

本题中，一棵高度平衡二叉树定义为：

> 一个二叉树*每个节点* 的左右两个子树的高度差的绝对值不超过1。

**示例 1:**

给定二叉树 `[3,9,20,null,null,15,7]`

```csharp
    3
   / \
  9  20
    /  \
   15   7
```

返回 `true` 。

**示例 2:**

给定二叉树 `[1,2,2,3,3,null,null,4,4]`

```csharp
       1
      / \
     2   2
    / \
   3   3
  / \
 4   4
```

返回 `false` 。

##  解答：

```csharp
static void Main(string[] args)
{
}
public bool IsBalanced(TreeNode root)
{
    if (root == null) 
    {
        return true;
    }
    return IsBalanced(root.left) && IsBalanced(root.right) && (Math.Abs(height(root.left) - height(root.right)) <= 1);
}
public int height(TreeNode root)
{
    if (root == null)
    {
        return -1;
    }
    return Math.Max(height(root.left), height(root.right)) + 1;
}
/*            如何获取高度
    *          1           4 > -1 > 0
    *         / \              -1
    *        2   2
    *       / \            3 > 0 > 1
    *      3   3               0
    *     / \
    *    4   4             2 > 1 > 2
    *                          0 
    *    注意：要考虑不是每个都是这样的工整，有缺的，要都考虑
*/
```

