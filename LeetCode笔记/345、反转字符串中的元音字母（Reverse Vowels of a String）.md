# 345、反转字符串中的元音字母（Reverse Vowels of a String）

## 题目：

编写一个函数，以字符串作为输入，反转该字符串中的元音字母。

 

**示例 1：**

```
输入："hello"
输出："holle"
```

**示例 2：**

```
输入："leetcode"
输出："leotcede"
```

 

**提示：**

- 元音字母不包含字母 "y" 。

## 解答：

法一：

```csharp
public string ReverseVowels(string s)
{
    if (s == null || s.Length < 2) 
    {
        return s;
    }
    char[] chars = s.ToCharArray();
    int left = 0;
    int right = s.Length - 1;
    while (left < right) 
    {
        while (left < s.Length && !isVowel(chars[left])) 
        {
            left++;
        }
        while (right >= 0 && !isVowel(chars[right])) 
        {
            right--;
        }
        if (left < right) 
        {
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            left++;
            right--;
        }
    }
    return new string(chars);
}
//判断字符是否为元音字母
public bool isVowel(char c)
{
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
        || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
}
```

