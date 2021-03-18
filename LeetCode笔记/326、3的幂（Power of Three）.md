# 326、3的幂（Power of Three）

## 题目：

给定一个整数，写一个函数来判断它是否是 3 的幂次方。如果是，返回 `true` ；否则，返回 `false` 。

整数 `n` 是 3 的幂次方需满足：存在整数 `x` 使得 `n == 3x`

 

**示例 1：**

```
输入：n = 27
输出：true
```

**示例 2：**

```
输入：n = 0
输出：false
```

**示例 3：**

```
输入：n = 9
输出：true
```

**示例 4：**

```
输入：n = 45
输出：false
```

 

**提示：**

- `-231 <= n <= 231 - 1`

 

**进阶：**

- 你能不使用循环或者递归来完成本题吗？

## 解答：

法一：

```csharp
//循环
public bool IsPowerOfThree(int n)
{
    if (n < 1)
    {
        return false;
    }

    while (n % 3 == 0)
    {
        n /= 3;
    }

    return n == 1;
}
```

法二：

```csharp
//递归
public bool IsPowerOfThree1(int n)
{
    if (n == 1)
    {
        return true;
    }
    else if (n == 0) 
    {
        return false;
    }
    return IsPowerOfThree1(n / 3) && n % 3 == 0;
}
```

法三：

```csharp
//偷鸡解法 把int最大的3次方求出来和取余
public bool IsPowerOfThree2(int n)
{
    if (n == 1)
    {
        return true;
    }
    if (n <= 0) 
    {
        return false;
    }
    return 1162261467 % n == 0;
}
```

法四：

```csharp
//换底公式
public bool IsPowerOfThree3(int n)
{
    if (n == 1)
    {
        return true;
    }
    if (n <= 0)
    {
        return false;
    }
    double a = Math.Log10(n) / Math.Log10(3);
    return a == Math.Floor(a);
}
```

