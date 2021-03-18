# 38、 外观数列（Count and Say）

## 题目：

给定一个正整数 *n*（1 ≤ *n* ≤ 30），输出外观数列的第 *n* 项。

注意：整数序列中的每一项将表示为一个字符串。

「外观数列」是一个整数序列，从数字 1 开始，序列中的每一项都是对前一项的描述。前五项如下：

```csharp
1.     1
2.     11
3.     21
4.     1211
5.     111221
```

第一项是数字 1

描述前一项，这个数是 `1` 即 “一个 1 ”，记作 `11`

描述前一项，这个数是 `11` 即 “两个 1 ” ，记作 `21`

描述前一项，这个数是 `21` 即 “一个 2 一个 1 ” ，记作 `1211`

描述前一项，这个数是 `1211` 即 “一个 1 一个 2 两个 1 ” ，记作 `111221`



**示例 1:**

```csharp
输入: 1
输出: "1"
解释：这是一个基本样例。
```

**示例 2:**

```csharp
输入: 4
输出: "1211"
解释：当 n = 3 时，序列是 "21"，其中我们有 "2" 和 "1" 两组，"2" 可以读作 "12"，也就是出现频次 = 1 而 值 = 2；类似 "1" 可以读作 "11"。所以答案是 "12" 和 "11" 组合在一起，也就是 "1211"。
```

## 解答：

 ```csharp
public static string CountAndSay(int n)
{
    if (n == 1)
    {
        return "1";
    }
    string rep = "1";
    for (int i = 2; i < n + 1; i++)
    {
        //每次迭代
        rep = GetNextCountAndSay(rep);
    }
    return rep;
}
public static string GetNextCountAndSay(string str)
{
    string rep = "";
    char target = str[0];
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == target)
        {
            count++;
        }
        else
        {
            rep = rep + count.ToString() + target;
            target = str[i];
            count = 1;
        }               
    }
    rep = rep + count.ToString() + target;
    return rep;
}
 ```

