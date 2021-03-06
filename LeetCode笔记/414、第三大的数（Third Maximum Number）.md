# 414、第三大的数（Third Maximum Number）

## 题目：

给你一个非空数组，返回此数组中 **第三大的数** 。如果不存在，则返回数组中最大的数。

 

**示例 1：**

```
输入：[3, 2, 1]
输出：1
解释：第三大的数是 1 。
```

**示例 2：**

```
输入：[1, 2]
输出：2
解释：第三大的数不存在, 所以返回最大的数 2 。
```

**示例 3：**

```
输入：[2, 2, 3, 1]
输出：1
解释：注意，要求返回第三大的数，是指第三大且唯一出现的数。
存在两个值为2的数，它们都排第二。
```

 

**提示：**

- `1 <= nums.length <= 104`
- `231 <= nums[i] <= 231 - 1`

 

**进阶：**你能设计一个时间复杂度 `O(n)` 的解决方案吗？

## 解答：

```csharp
public static int ThirdMax(int[] nums)
{
    //比较然后挨个赋值
    long firstMax = long.MinValue;
    long secondMax = long.MinValue;
    long thirdMax = long.MinValue;

    foreach (int num in nums)
    {
        if (num.Equals(firstMax) || num.Equals(secondMax) || num.Equals(thirdMax))
        {
            continue;
        }
        if (num > firstMax)
        {
            thirdMax = secondMax;
            secondMax = firstMax;
            firstMax = num;
        }
        else if (num > secondMax && num < firstMax)
        {
            thirdMax = secondMax;
            secondMax = num;
        }
        else if (num > thirdMax && num < secondMax) 
        {
            thirdMax = num;
        }
    }
    if (thirdMax == long.MinValue)
    {
        return (int)firstMax;
    }
    return (int)thirdMax;
}
```

