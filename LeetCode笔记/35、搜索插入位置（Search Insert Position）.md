# 35、搜索插入位置（Search Insert Position）

## 题目：

给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。

你可以假设数组中无重复元素。

**示例 1:**

```csharp
输入: [1,3,5,6], 5
输出: 2
```

**示例 2:**

```csharp
输入: [1,3,5,6], 2
输出: 1
```

**示例 3:**

```csharp
输入: [1,3,5,6], 7
输出: 4
```

**示例 4:**

```csharp
输入: [1,3,5,6], 0
输出: 0
```

## 解答：

都是二分法，推荐第一个。

**法一**：

```csharp
public static int SearchInsert(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;
    while (left <= right) 
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] == target)
        {
            return mid;
        }
        else if (nums[mid] > target) 
        {
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }
    }
    return left;
}
```

**法二：**

```csharp
public static int SearchInsert1(int[] nums, int target)
{
    if (nums == null || nums.Length == 0)
    {
        return 0;
    }
    int left = 0;
    int right = nums.Length - 1;
    while (left + 1 < right)
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] == target)
        {
            return mid;
        }
        if (nums[mid] < target)
        {
            left = mid;
        }
        else
        {
            right = mid;
        }
    }
    if (nums[left] >= target)
    {
        return left;
    }
    else if (nums[left] < target && target <= nums[right])
    {
        return right;
    }
    else
    {
        return nums.Length;
    }
}
```

