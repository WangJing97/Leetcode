# 434、字符串中的单词数（Number of Segments in a String）

## 题目：

统计字符串中的单词个数，这里的单词指的是连续的不是空格的字符。

请注意，你可以假定字符串里不包括任何不可打印的字符。

**示例:**

```
输入: "Hello, my name is John"
输出: 5
解释: 这里的单词是指连续的不是空格的字符，所以 "Hello," 算作 1 个单词。
```

## 解答：

法一：

```csharp
public static int CountSegments(string s)
{
    //找空格
    int count = 0;
    bool lastIsBlank = true;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ' ')
        {
            lastIsBlank = true;
        }
        else
        {
            if (lastIsBlank)
            {
                count++;
            }
            lastIsBlank = false;
        }
    }
    return count;
}
```

法二：

```csharp
public static int CountSegments1(string s)
{
    int count = 0;
    foreach (string item in s.Split(' '))
    {
        if (string.IsNullOrEmpty(item)) 
        {
            continue;
        }
        count++;
    }
    return count;
}
```