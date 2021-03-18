# 108、将有序数组转换为二叉搜索树（Convert Sorted Array to Binary Search Tree）

## 题目：

将一个按照升序排列的有序数组，转换为一棵高度平衡二叉搜索树。

本题中，一个高度平衡二叉树是指一个二叉树*每个节点* 的左右两个子树的高度差的绝对值不超过 1。

**示例:**

```csharp
给定有序数组: [-10,-3,0,5,9],

一个可能的答案是：[0,-3,9,-10,null,5]，它可以表示下面这个高度平衡二叉搜索树：

      0
     / \
   -3   9
   /   /
 -10  5
```

## 解答：

```csharp
public TreeNode SortedArrayToBST(int[] nums)
{
    if (nums.Length == 0) 
    {
        return null;
    }
    TreeNode root = helper(nums, 0, nums.Length - 1);
    return root;
}
public TreeNode helper(int[] nums, int low, int high)
{
    //把中间的提起来。左边的小一点
    if (low > high) 
    {
        return null;
    }
    //这样可以防止泄露，不推荐(low+high)/2
    int mid = low + (high - low) / 2;
    //把新的mid作为root
    TreeNode node = new TreeNode(nums[mid]);
    node.left = helper(nums, low, mid - 1);
    node.right = helper(nums, mid + 1, high);
    return node;
}
```

