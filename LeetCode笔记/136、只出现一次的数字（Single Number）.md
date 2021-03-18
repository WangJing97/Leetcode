# 136、只出现一次的数字（Single Number）

## 题目：

给定一个**非空**整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

**说明：**

你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

**示例 1:**

```csharp
输入: [2,2,1]
输出: 1
```

**示例 2:**

```csharp
输入: [4,1,2,1,2]
输出: 4
```

## 解答：

法一：

```csharp
public int SingleNumber(int[] nums)
{
    //如果我们对0和二进制数做异或计算，得到的数仍然是这个二进制数
    //如果我们对相同的二进制数做异或计算，得到的数则是0
    //同一个数做两次异或的结果0
    //所以相同的数就会被变成0
    for (int i = 1; i < nums.Length; i++)
    {
        nums[0] ^= nums[i];
    }
    return nums[0];
}
```

法二：

```csharp
public int SingleNumber1(int[] nums)
{
    //Hash表的add返回值是bool
    //如果该元素添加到 HashSet<T> 对象中则为true；如果该元素已存在则为 false。 
    HashSet<int> HS = new HashSet<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (!HS.Add(nums[i])) 
        {
            HS.Remove(nums[i]);
        }
    }
    return HS.First();
}
```



