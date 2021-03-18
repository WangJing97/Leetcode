# 217、存在重复元素（Contains Duplicate）

## 题目：

给定一个整数数组，判断是否存在重复元素。

如果任意一值在数组中出现至少两次，函数返回 `true` 。如果数组中每个元素都不相同，则返回 `false` 。

**示例 1:**

```
输入: [1,2,3,1]
输出: true
```

**示例 2:**

```
输入: [1,2,3,4]
输出: false
```

**示例 3:**

```
输入: [1,1,1,3,3,4,3,2,4,2]
输出: true
```

## 解答：

法一：

```csharp
//简单的遍历 但是会超时
public bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (nums[i] == nums[j]) 
            {
                return true;
            }
        }
    }
    return false;
}
```

法二：

```csharp
//利用HashSet的特性 添加重复的会返回fasle
public bool ContainsDuplicate1(int[] nums)
{
    if (nums == null || nums.Length <= 1)  
    {
        return false;
    }
    HashSet<int> HS = new HashSet<int>();
    foreach (int item in nums)
    {
        if (!HS.Add(item))
        {
            return true;
        }
    }
    return false;
}
```

法三：

```csharp
public bool ContainsDuplicate2(int[] nums)
{
    if (nums == null || nums.Length <= 1)
    {
        return false;
    }
    Array.Sort(nums);
    int pre = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == pre) 
        {
            return true;
        }
        else
        {
            pre = nums[i];
        }
    }
    return false;
}
```

