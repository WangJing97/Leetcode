# 69、x 的平方根（Sqrt(x)）

## 题目：

实现 `int sqrt(int x)` 函数。

计算并返回 *x* 的平方根，其中 *x* 是非负整数。

由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。

**示例 1:**

```
输入: 4
输出: 2
```

**示例 2:**

```
输入: 8
输出: 2
说明: 8 的平方根是 2.82842..., 
     由于返回类型是整数，小数部分将被舍去。
```

## 解答：

二分法：

```csharp
public static int MySqrt(int x)
{
    if (x == 1)
    {
        return 1;
    }
    long left = 0;
    //平方可以在一半开始找
    long right = x / 2;
    long mid;
    while (left <= right) 
    {
        mid = (left + right) / 2;
        //防止溢出
        if (mid * mid > int.MaxValue)
        {
            right = mid - 1;
        }
        if (mid * mid == x)
        {
            return (int)mid;
        }
        else if (mid * mid > x)
        {
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }

    }
    return (int)right;
}

```

