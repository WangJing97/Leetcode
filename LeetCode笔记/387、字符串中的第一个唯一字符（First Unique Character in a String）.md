# 387、字符串中的第一个唯一字符（First Unique Character in a String）

## 题目：

给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。

 

**示例：**

```
s = "leetcode"
返回 0

s = "loveleetcode"
返回 2
```

 

**提示：**你可以假定该字符串只包含小写字母。

## 解答：

法一：

```csharp
public int FirstUniqChar(string s)
{
    Dictionary<char, int> dic = new Dictionary<char, int>();
    //统计每个字母的数量
    for (int i = 0; i < s.Length; i++)
    {
        if (dic.ContainsKey(s[i])) 
        {
            dic[s[i]] += 1;
        }
        else
        {
            dic.Add(s[i], 1);
        }
    }
    for (int i = 0; i < s.Length; i++)
    {
        if (dic[s[i]] == 1) 
        {
            return i;
        }
    }
    return -1;
}
```

法二：

```csharp
public int FirstUniqChar1(string s)
{
    int[] count = new int[26];
    char[] chars = s.ToArray();
    //先统计字符串的次数
    for (int i = 0; i < s.Length; i++)
    {
        count[chars[i] - 'a']++;
    }
    //遍历技术数组
    for (int i = 0; i < s.Length; i++)
    {
        if (count[chars[i] - 'a'] == 1) 
        {
            return i;
        }
    }
    return -1;
}
```

