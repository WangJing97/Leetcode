# 231、2的幂（Power of Two）

## 题目：

给定一个整数，编写一个函数来判断它是否是 2 的幂次方。

**示例 1:**

```
输入: 1
输出: true
解释: 20 = 1
```

**示例 2:**

```
输入: 16
输出: true
解释: 24 = 16
```

**示例 3:**

```
输入: 218
输出: false
```

## 解答：

<img src="D:\PC\LeetCode\231、2的幂（Power of Two）.assets\Screenshot_20201123_093146.jpg" alt="Screenshot_20201123_093146" style="zoom:33%;" />

法一：

```csharp
public static bool IsPowerOfTwo(int n)
{
    if (n <= 0) 
    {
        return false;
    }
    int count = 0;
    for (int i = 0; i < 32; i++)
    {
        if ((n & 1) == 1) 
        {
            count++;
        }
        n >>= 1;
    }
    return count == 1;
}
```

法二：

```csharp
public static bool IsPowerOfTwo1(int n)
{
    return n > 0 && ((n & (n - 1)) == 0);
}
```

