# 125、验证回文串（Valid Palindrome）

## 题目：

给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。

**说明：**本题中，我们将空字符串定义为有效的回文串。

**示例 1:**

```csharp
输入: "A man, a plan, a canal: Panama"
输出: true
```

**示例 2:**

```csharp
输入: "race a car"
输出: false
```

## 解答：

法一：

```csharp
public bool IsPalindrome(string s)
{
    if (s == null || s.Length == 0)
    {
        return true;
    }
    int i = 0;
    int j = s.Length - 1;

    while (i <= j)
    {
        while (i <= j && !char.IsLetterOrDigit(s[i]))
        {
            i++;
        }
        while (i <= j && !char.IsLetterOrDigit(s[j]))
        {
            j--;
        }
        if (i <= j && char.ToLower(s[i]) != char.ToLower(s[j]))
        {
            return false;
        }
        i++;
        j--;
    }
    return true;
}
```

法二：

```csharp
public bool IsPalindrome1(string s)
{
    s = s.ToLower();
    string str = "qwertyuiopasdfghjklzxcvbnm0123456789";
    List<char> strc = new List<char>();
    foreach (char item in s)
    {
        if (str.Contains(item)) 
        {
            strc.Add(item);
        }
    }
    int i = 0;
    int j = strc.Count - 1;
    while (i < j)
    {
        if (strc[i] != strc[j]) 
        {
            return false;
        }
        else
        {
            i++;
            j--;
        }
    }
    return true;
}
```

