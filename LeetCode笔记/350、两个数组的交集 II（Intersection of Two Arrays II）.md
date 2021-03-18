# 350、两个数组的交集 II（Intersection of Two Arrays II）

## 解答：

给定两个数组，编写一个函数来计算它们的交集。

 

**示例 1：**

```
输入：nums1 = [1,2,2,1], nums2 = [2,2]
输出：[2,2]
```

**示例 2:**

```
输入：nums1 = [4,9,5], nums2 = [9,4,9,8,4]
输出：[4,9]
```

 

**说明：**

- 输出结果中每个元素出现的次数，应与元素在两个数组中出现次数的最小值一致。
- 我们可以不考虑输出结果的顺序。

***\*进阶\**：**

- 如果给定的数组已经排好序呢？你将如何优化你的算法？
- 如果 *nums1* 的大小比 *nums2* 小很多，哪种方法更优？
- 如果 *nums2* 的元素存储在磁盘上，内存是有限的，并且你不能一次加载所有的元素到内存中，你该怎么办？

## 解答：

法一：

```csharp
public int[] Intersect(int[] nums1, int[] nums2)
{
    //解题思路
    //首先遍历第一个数组，记录数组中每个数字的值和出现的频率
    //接着遍历第二个数组中的每个数字，如果表中存在这个数字，则将这个数字添加到答案，并且
    //减少表中的次数
    Dictionary<int, int> dic = new Dictionary<int, int>();
    List<int> res = new List<int>();
    foreach (int n in nums1) 
    {
        if (dic.ContainsKey(n)) 
        {
            dic[n]++;
        }
        else
        {
            dic.Add(n, 1);
        }
    }
    foreach (int n in nums2)
    {
        if (dic.ContainsKey(n) && dic[n] > 0) 
        {
            dic[n]--;
            res.Add(n);
        }
    }
    return res.ToArray();
}
```

法二：

```csharp
public int[] Intersect1(int[] nums1, int[] nums2)
{
    Array.Sort(nums1);
    Array.Sort(nums2);
    int i = 0;
    int j = 0;
    List<int> res = new List<int>();
    while (i < nums1.Length && j < nums2.Length) 
    {
        //两个指针，谁小谁++；
        if (nums1[i] < nums2[j])
        {
            i++;
        }
        else if (nums1[i] > nums2[j]) 
        {
            j++;
        }
        else
        {
            res.Add(nums1[i]);
            i++;
            j++;
        }
    }
    return res.ToArray();
}
```

