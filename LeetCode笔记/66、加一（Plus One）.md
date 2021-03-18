# 66、加一（Plus One）

## 题目：

给定一个由**整数**组成的**非空**数组所表示的非负整数，在该数的基础上加一。

最高位数字存放在数组的首位， 数组中每个元素只存储**单个**数字。

你可以假设除了整数 0 之外，这个整数不会以零开头。

**示例 1:**

```csharp
输入: [1,2,3]
输出: [1,2,4]
解释: 输入数组表示数字 123。
```

**示例 2:**

```csharp
输入: [4,3,2,1]
输出: [4,3,2,2]
解释: 输入数组表示数字 4321。
```

## 解答：

都是同一种思路，写法不一样：

```csharp
public static int[] PlusOne(int[] digits)
{
    int i = digits.Length - 1;
    while (i >= 0)
    {
        if (digits[i] < 9)
        {
            digits[i] += 1;
            return digits;
        }
        digits[i] = 0;
        i--;
    }
    int[] res = new int[digits.Length + 1];
    res[0] = 1;
    return res;
}
```

```csharp
public static int[] PlusOne1(int[] digits)
{
    int flag = 1;
    for (int i = digits.Length - 1; i >= 0; i--) 
    {
        int temp = digits[i] + flag;
        if (temp >= 10)
        {
            flag = 1;
            digits[i] = temp - 10;
        }
        else
        {
            digits[i] = temp;
            flag = 0;
            break;
        }
    }
    if (flag == 0) 
    {
        return digits;
    }
    int[] res = new int[digits.Length + 1];
    res[0] = 1;
    for (int i = 0; i < digits.Length; i++)
    {
        res[i + 1] = digits[i];
    }
    return res;
}
```



