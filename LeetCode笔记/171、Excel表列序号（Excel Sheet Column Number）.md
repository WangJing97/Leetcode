# 171、Excel表列序号（Excel Sheet Column Number）

## 题目：

给定一个Excel表格中的列名称，返回其相应的列序号。

例如，

```csharp
A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
```
示例 1:

```csharp
输入: "A"
输出: 1
```


示例 2:

```csharp
输入: "AB"
输出: 28
```


示例 3:

```csharp
输入: "ZY"
输出: 701
```

## 解答：

```csharp
public int TitleToNumber(string s)
{
    //如何找到一个字母表的字母的数字：
    //'A'=65
    //将这个字母和'A'做减法再加一，H = 72
    //72-65+1=8。-->num = 字母 - 'A' + 1
    //循环找数的时候26个其实到的是Z，要想找到没到Z的字母数就要加上上面算的值
    //遍历次数设res，初始值0
    //res = res * 26 + num
    int res = 0;
    int num = 0;
    for (int i = 0; i < s.Length; i++)
    {
        num = s[i] - 'A' + 1;
        res = res * 26 + num;
    }
    return res;
}
```

