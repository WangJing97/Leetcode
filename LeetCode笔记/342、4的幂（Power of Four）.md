# 342、4的幂（Power of Four）

## 题目：

给定一个整数，写一个函数来判断它是否是 4 的幂次方。如果是，返回 `true` ；否则，返回 `false` 。

整数 `n` 是 4 的幂次方需满足：存在整数 `x` 使得 `n == 4x`

 

**示例 1：**

```
输入：n = 16
输出：true
```

**示例 2：**

```
输入：n = 5
输出：false
```

**示例 3：**

```
输入：n = 1
输出：true
```

 

**提示：**

- `-231 <= n <= 231 - 1`

 

**进阶：**

- 你能不使用循环或者递归来完成本题吗？

## 解答：

法一：

```csharp
public bool IsPowerOfFour(int n)
{
    if (n == 0)
    {
        return false;
    }                
    while (n % 4 == 0)
    {
        n /= 4;
    }               
    return n == 1;
}
```

法二：

```csharp
public bool IsPowerOfFour1(int n)
{
    //x = 4^a，则a = log4(x) = 1/2log2(x)就是整数，也就是log2(x)是偶数就行
    return (n > 0) && (Math.Log(n) / Math.Log(2) % 2 == 0);
}
```

法三：

```csharp
public bool IsPowerOfFour2(int n)
{
    //是否是 2 的幂次方数使用的是位运算 n & ( n - 1 )
    //4的次方数一定是2的次方数，但2的次方数不一定是4的次方数，
    //通过4的次方数二进制可以发现4的次方数二进制中1只出现在奇数位。
    //因此可以通过于奇数位都是1，偶数为都是0的数（1010101010101010101010101010101）进行与运算，
    //结果仍为原来数。
    //转换成 16 进制表示：0x55555555
    if (n <= 0) 
    {
        return false;
    }
    //先判断是否是2的幂
    if ((n & n - 1) != 0) 
    {
        return false;
    }
    if ((n & 0x55555555) == n) 
    {
        return true;
    }
    return false;
}
```

