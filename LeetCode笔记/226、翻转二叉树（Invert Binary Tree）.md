# 226、翻转二叉树（Invert Binary Tree）

## 题目：

翻转一棵二叉树。

**示例：**

输入：

```
     4
   /   \
  2     7
 / \   / \
1   3 6   9
```

输出：

```
     4
   /   \
  7     2
 / \   / \
9   6 3   1
```

**备注:**
这个问题是受到 [Max Howell ](https://twitter.com/mxcl)的 [原问题](https://twitter.com/mxcl/status/608682016205344768) 启发的 ：

![226_2.gif](D:\PC\LeetCode\226、翻转二叉树（Invert Binary Tree）.assets\0f91f7cbf5740de86e881eb7427c6c3993f4eca3624ca275d71e21c5e3e2c550-226_2.gif)

## 解答：

```csharp
public TreeNode InvertTree(TreeNode root)
{
    //使用递归每个左右子树先反转，每个节点也是和子树一样，递归即可
    if (root == null) 
    {
        return root;
    }
    var temp = root.left;
    root.left = root.right;
    root.right = temp;
    InvertTree(root.left);
    InvertTree(root.right);
    return root;
}
```

