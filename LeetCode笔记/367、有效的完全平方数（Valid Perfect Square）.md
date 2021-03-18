# 367、有效的完全平方数（Valid Perfect Square）

## 题目：

给定一个正整数 *num*，编写一个函数，如果 *num* 是一个完全平方数，则返回 True，否则返回 False。

**说明：**不要使用任何内置的库函数，如 `sqrt`。

**示例 1：**

```
输入：16
输出：True
```

**示例 2：**

```
输入：14
输出：False
```

## 解答：

法一：

```csharp
public static bool IsPerfectSquare(int num)
{
    //最暴力的方法一个一个试
    int i = 1;
    while (i * i < num)
    {
        i += 1;
    }
    return i * i == num;
}
```

法二：

```csharp
public bool IsPerfectSquare1(int num)
{
    //利用二分法找，再加上完全平方数的性质：它的个位数都是0，1，4，5，6，9
    //先利用完全平方性质
    int a = num % 10;
    if (a != 0 && a != 1 && a != 4 && a != 5 && a != 6 && a != 9) 
    {
        return false;
    }
    int left = 0;
    int right = num;
    while (left <= right) 
    {
        int mid = left + (right - left) / 2;
        if ((long)mid * mid == num)
        {
            return true;
        }
        else if (num > (long)mid * mid) 
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return false;
}
```

法三：

```csharp
public bool IsPerfectSquare2(int num)
{
    //利用公式
    //1+3+5+7+...+(2n-1)=n^2
    int i = 1;
    while (num > 0) 
    {
        num -= i;
        i += 2;
    }
    return num == 0;
}
```

法四：

```csharp
public bool IsPerfectSquare3(int num)
{
    //?牛顿迭代法
    if (num < 2)
    {
        return true;
    }
    long x = num / 2;
    while (x * x > num)
    {
        x = (x + num / x) / 2;
    }
    return (x * x == num);
}
```

