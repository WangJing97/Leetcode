# 349、两个数组的交集（Intersection of Two Arrays）

## 题目：

给定两个数组，编写一个函数来计算它们的交集。

 

**示例 1：**

```
输入：nums1 = [1,2,2,1], nums2 = [2,2]
输出：[2]
```

**示例 2：**

```
输入：nums1 = [4,9,5], nums2 = [9,4,9,8,4]
输出：[9,4]
```

 

**说明：**

- 输出结果中的每个元素一定是唯一的。
- 我们可以不考虑输出结果的顺序。

## 解答：

法一：

```csharp
public int[] Intersection(int[] nums1, int[] nums2)
{
    //求交集的方法
    IEnumerable<int> both = nums1.Intersect(nums2);
    return both.ToArray();
}
```

法二：

```csharp
public int[] Intersection1(int[] nums1, int[] nums2)
{
    List<int> num1 = nums1.Distinct().ToList();
    List<int> num2 = nums2.Distinct().ToList();
    List<int> res = new List<int>();

    for (int i = 0; i < num2.Count; i++) 
    {
        if (num1.Contains(num2[i])) 
        {
            res.Add(num2[i]);
        }
    }
    return res.ToArray();
}
```

