# 168、Excel表列名称（Excel Sheet Column Title）

## 题目：

给定一个正整数，返回它在 Excel 表中相对应的列名称。

例如，

```csharp
    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 
    ...
```

**示例 1:**

```csharp
输入: 1
输出: "A"
```

**示例 2:**

```csharp
输入: 28
输出: "AB"
```

**示例 3:**

```csharp
输入: 701
输出: "ZY"
```

## 解答：

```csharp
public static string ConvertToTitle(int n)
{
    //StringBuilder sb = new StringBuilder();
    string str = string.Empty;
    while (n > 0)
    {
        //使用StringBuilder最后需要把字符串进行反转
        //注意这里的n-- 要注意往后加不包括自己
        n--;
        //sb.Append((char)('A' + n % 26));
        //ASCII码的65就是A
        str = (char)(65 + n % 26) + str;
        n = n / 26;
    }
    return str;
}
```

