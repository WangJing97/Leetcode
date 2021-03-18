# 58、最后一个单词的长度（Length of Last Word）

## 题目：

给定一个仅包含大小写字母和空格 `' '` 的字符串 `s`，返回其最后一个单词的长度。如果字符串从左向右滚动显示，那么最后一个单词就是最后出现的单词。

如果不存在最后一个单词，请返回 0 。

**说明：**一个单词是指仅由字母组成、不包含任何空格字符的 **最大子字符串**。

**示例:**

```csharp
输入: "Hello World"
输出: 5
```

## 解答：

```csharp
public static int LengthOfLastWord(string s)
{
    if (s == null || s.Length == 0)
    {
        return 0;
    }
    //如果末尾是' '就继续往后找
    int i = s.Length - 1;
    while (i >= 0 && s[i] == ' ') 
    {
        i--;
    }
    //如果末尾不是' '就开始计数
    int count = 0;
    while (i >= 0 && s[i] != ' ') 
    {
        i--;
        count++;
    }
    return count;
}
```

