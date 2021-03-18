# 235、二叉搜索树的最近公共祖先（Lowest Common Ancestor of a Binary Search Tree）

## 题目：

给定一个二叉搜索树, 找到该树中两个指定节点的最近公共祖先。

[百度百科](https://baike.baidu.com/item/最近公共祖先/8918834?fr=aladdin)中最近公共祖先的定义为：“对于有根树 T 的两个结点 p、q，最近公共祖先表示为一个结点 x，满足 x 是 p、q 的祖先且 x 的深度尽可能大（**一个节点也可以是它自己的祖先**）。”

例如，给定如下二叉搜索树: root = [6,2,8,0,4,7,9,null,null,3,5]

![img](https://assets.leetcode-cn.com/aliyun-lc-upload/uploads/2018/12/14/binarysearchtree_improved.png)

 

**示例 1:**

```
输入: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
输出: 6 
解释: 节点 2 和节点 8 的最近公共祖先是 6。
```

**示例 2:**

```
输入: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 4
输出: 2
解释: 节点 2 和节点 4 的最近公共祖先是 2, 因为根据定义最近公共祖先节点可以为节点本身。
```

 

**说明:**

- 所有节点的值都是唯一的。
- p、q 为不同节点且均存在于给定的二叉搜索树中。

## 解答：

![Screenshot_20201130_170557_com.newskyer.draw_edit](D:\PC\LeetCode\235、二叉搜索树的最近公共祖先（Lowest Common Ancestor of a Binary Search Tree）.assets\Screenshot_20201130_170557_com.newskyer.draw_edit.jpg)

    利用 二叉搜索树 的性质：
    左 > 根 > 右
    利用这个性质可以推断出p q与root的关系
    若 root.val < p.val ，则 p 在 root 右子树 中；
    若 root.val > p.val ，则 p 在 root 左子树 中；
    若 root.val = p.val ，则 p 和 root 指向 同一节点 。
    第一种方法 迭代
    当 p, q 都在 root 的 右子树 中，则遍历至 root.right ；
    否则，当 p, q 都在 root 的 左子树 中，则遍历至 root.left ；
    否则，说明找到了 最近公共祖先 ，跳出。
    第二种方法 递归
    看图
法一（迭代）：

```csharp
public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
{
    while (root != null) 
    {
        //p，q都在root的右子树中
        if (root.val < p.val && root.val < q.val)
        {
            //遍历右子节点
            root = root.right;
        }
        //p，q都在root的左子树中
        else if (root.val > p.val && root.val > q.val)
        {
            //遍历左子节点
            root = root.left;
        }
        else break;
    }
    return root;
}
```

法二（递归）：

```csharp
public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
{
    if (root == null)
    {
        return null;
    }
    if (root == p || root == q) 
    {
        return root;
    }
    TreeNode left = LowestCommonAncestor1(root.left, p, q);
    TreeNode right = LowestCommonAncestor1(root.right, p, q);
    if (left != null && right != null) 
    {
        return root;
    }
    if (left == null && right == null) 
    {
        return null;
    }
    return left != null ? left : right;
}
```

