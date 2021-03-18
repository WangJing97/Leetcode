# 383、赎金信（Ransom Note）

## 题目：

给定一个赎金信 (`ransom`) 字符串和一个杂志(`magazine`)字符串，判断第一个字符串 `ransom` 能不能由第二个字符串 `magazines` 里面的字符构成。如果可以构成，返回 `true` ；否则返回 `false`。

(题目说明：为了不暴露赎金信字迹，要从杂志上搜索各个需要的字母，组成单词来表达意思。杂志字符串中的每个字符只能在赎金信字符串中使用一次。)

 

**注意：**

你可以假设两个字符串均只含有小写字母。

```
canConstruct("a", "b") -> false
canConstruct("aa", "ab") -> false
canConstruct("aa", "aab") -> true
```

## 解答：

法一：

```csharp
public bool CanConstruct(string ransomNote, string magazine)
{
    //键为字符，值为字符对应的个数
    //找就行
    if (ransomNote.Length > magazine.Length) 
    {
        return false; 
    }
    Dictionary<char, int> dic = new Dictionary<char, int>();
    foreach (char c in magazine)
    {
        if (!dic.ContainsKey(c))
        {
            dic[c] = 1;
        }
        else
        {
            dic[c]++;
        }
    }
    foreach (char c in ransomNote)
    {
        if (!dic.ContainsKey(c))
        {
            return false;
        }
        else
        {
            if (dic[c] > 0) 
            {
                dic[c]--;
            }
            else
            {
                return false;
            }
        }
    }
    return true;
}
```

