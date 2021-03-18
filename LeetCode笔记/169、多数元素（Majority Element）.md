# 169、多数元素（Majority Element）

## 题目：

给定一个大小为 *n* 的数组，找到其中的多数元素。多数元素是指在数组中出现次数**大于** `⌊ n/2 ⌋` 的元素。

你可以假设数组是非空的，并且给定的数组总是存在多数元素。

**示例 1:**

```csharp
输入: [3,2,3]
输出: 3
```

**示例 2:**

```csharp
输入: [2,2,1,1,1,2,2]
输出: 2
```

## 解答：

法一：自带函数

```csharp
public int MajorityElement(int[] nums)
{
    //对这个数组进行排序 找最中间的数就是多数元素
    //因为这个数组是非空的，并且给定的数组总是存在多数元素
    Array.Sort(nums);
    return nums[(nums.Length - 1) / 2];
}
```

法二：摩尔投票法

```csharp
public int MajorityElement1(int[] nums)
{
    //摩尔投票法
    //过程：
    //首先初始化两个量：众数和票数，众数初值设置为数组的第一个元素，票数为0
    //往后遍历，遇到相同的数则票数加一，否则减一
    //如果全部抵消票数为0，则设下一个数为当前数
    //最后的当前数就是众数
    //初始化
    int mode = nums[0];
    int votes = 0;
    //遍历找数
    for (int i = 0; i < nums.Length; i++)
    {
        if (votes == 0)
        {
            mode = nums[i];
        }
        if (nums[i] == mode) 
        {
            votes++;
        }
        else
        {
            votes--;
        }
    }
    return mode;
}
```

