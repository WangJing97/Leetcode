# 263、丑数（Ugly Number）

## 题目：

编写一个程序判断给定的数是否为丑数。

丑数就是只包含质因数 `2, 3, 5` 的**正整数**。

**示例 1:**

```
输入: 6
输出: true
解释: 6 = 2 × 3
```

**示例 2:**

```
输入: 8
输出: true
解释: 8 = 2 × 2 × 2
```

**示例 3:**

```
输入: 14
输出: false 
解释: 14 不是丑数，因为它包含了另外一个质因数 7。
```

**说明：**

1. `1` 是丑数。
2. 输入不会超过 32 位有符号整数的范围: [−231, 231 − 1]。

## 解答：

```csharp
public static bool IsUgly(int num)
{
    if (num <= 0) 
    {
        return false;
    }
    int[] factors = new int[] { 2, 3, 5 };
    foreach (int item in factors) 
    {
        //分别用丑数的因子去除
        while (num % item == 0)
        {
            num /= item;
        }
    }
    return num == 1;
}
```

```csharp
public static bool IsUgly1(int num)
{
    //利用递归往下找
    if (num == 0) return false;
    if (num == 1) return true;
    if (num % 2 == 0) return IsUgly1(num / 2);
    if (num % 3 == 0) return IsUgly1(num / 3);
    if (num % 5 == 0) return IsUgly1(num / 5);
    return false;
}
```

