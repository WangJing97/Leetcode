# 257、二叉树的所有路径（Binary Tree Paths）

## 题目：

给定一个二叉树，返回所有从根节点到叶子节点的路径。

**说明:** 叶子节点是指没有子节点的节点。

**示例:**

```
输入:

   1
 /   \
2     3
 \
  5

输出: ["1->2->5", "1->3"]

解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3
```

## 解答：

```csharp
public IList<string> BinaryTreePaths(TreeNode root)
{
    List<string> res = new List<string>();
    DFS(res, root, "");
    return res;
}
//使用递归
void DFS(List<string> res, TreeNode root, string path)
{
    if (root == null) 
    {
        return;
    }
    path += Convert.ToString(root.val);
    DFS(res, root.left, path + "->");
    DFS(res, root.right, path + "->");
    if (root.left == null && root.right == null) 
    {
        res.Add(path);
    }
}
```

