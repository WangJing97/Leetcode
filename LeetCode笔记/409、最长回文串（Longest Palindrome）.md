# 409、最长回文串（Longest Palindrome）

## 题目：

给定一个包含大写字母和小写字母的字符串，找到通过这些字母构造成的最长的回文串。

在构造过程中，请注意区分大小写。比如 `"Aa"` 不能当做一个回文字符串。

**注意:**
假设字符串的长度不会超过 1010。

**示例 1:**

```
输入:
"abccccdd"

输出:
7

解释:
我们可以构造的最长的回文串是"dccaccd", 它的长度是 7。
```

## 解答：

```csharp
public int LongestPalindrome(string s)
{
    //思路就是统计每个字符串出现的次数，偶数次放在两边，奇数放在中间 偶数直接加 奇数减一个最后加上中间的一位
    Dictionary<char, int> res = new Dictionary<char, int>();
    foreach (char c in s)
    {
        if (res.ContainsKey(c))
        {
            res[c]++;
        }
        else
        {
            res.Add(c, 1);
        }
    }
    bool flag = false;
    int sum = 0;
    foreach (var item in res) 
    {
        if (item.Value % 2 == 0) 
        {
            sum += item.Value;
        }
        else
        {
            sum += item.Value - 1;
            flag = true;
        }
    }
    if (flag)
    {
        sum += 1;
    }
    return sum;
}
```

