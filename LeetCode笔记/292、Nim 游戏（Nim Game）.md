# 292、Nim 游戏（Nim Game）

## 题目：

你和你的朋友，两个人一起玩 [Nim 游戏](https://baike.baidu.com/item/Nim游戏/6737105)：

- 桌子上有一堆石头。
- 你们轮流进行自己的回合，你作为先手。
- 每一回合，轮到的人拿掉 1 - 3 块石头。
- 拿掉最后一块石头的人就是获胜者。

假设你们每一步都是最优解。请编写一个函数，来判断你是否可以在给定石头数量为 `n` 的情况下赢得游戏。如果可以赢，返回 `true`；否则，返回 `false` 。

 

**示例 1：**

```
输入：n = 4
输出：false 
解释：如果堆中有 4 块石头，那么你永远不会赢得比赛；
     因为无论你拿走 1 块、2 块 还是 3 块石头，最后一块石头总是会被你的朋友拿走。
```

**示例 2：**

```
输入：n = 1
输出：true
```

**示例 3：**

```
输入：n = 2
输出：true
```

 

**提示：**

- `1 <= n <= 231 - 1`

## 解答：

法一（递归）：

```csharp
//会超时
public bool CanWinNim(int n)
{
    //递归
    //先写出赢了的情况
    if (n == 0) 
    {
        return false;
    }
    if (n <= 3) 
    {
        return true;
    }
    //考虑可能的几种情况
    //自己拿走1 2 3个之后在判断无论对方拿走几个，剩下的你是不是稳赢
    for (int i = 0; i <= 3; i++)
    {
        //不管对手怎么拿，你都稳赢
        if (CanWinNim(n - i - 1) && CanWinNim(n - i - 2) && CanWinNim(n - i - 3)) 
        {
            return true;
        }
    }
    //否则就是你输了
    return false;
}
```

法二（动态规划）：

```csharp
public bool CanWinNim1(int n)
{
    //列一个表
    //1 2 3 4 5 6 7 8
    //T T T F T T T F
    //表的意思就是当前还剩的数目，你会不会赢，之前有关系
    //往前看三个，其中只要有一个是F的，这个位置上的数就是T
    if (n < 4) 
    {
        return true;
    }
    bool[] b = new bool[n + 1];
    Boolean
        //b[0] = false;
        b[1] = true;
    b[2] = true;
    b[3] = true;
    for (int i = 4; i <= n; i++)
    {
        b[i] = !b[i - 1] || !b[i - 2] || !b[i - 3];
    }
    return b[n];
}
```

```csharp
public bool CanWinNim2(int n)
{
    //注意观察以上的数组其实最多用了4个，可以简化
    if (n < 4)
    {
        return true;
    }
    bool[] b = new bool[4];
    b[0] = false;
    b[1] = true;
    b[2] = true;
    b[3] = true;
    for (int i = 4; i <= n; i++)
    {
        b[i % 4] = !b[(i - 1) % 4] || !b[(i - 2) % 4] || !b[(i - 3) % 4];
    }
    return b[n % 4];
}
```

法三（观察数学规律）：

```csharp
public bool CanWinNim3(int n)
{
    //3 个 true ，1 个 false ，由此往复。
    return n % 4 != 0;
}
```

